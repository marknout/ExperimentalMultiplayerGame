using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{

    public bool moveWhenPlayerIsOn;
    public bool isPhysical;
    public Transform[] positions;
    [HideInInspector]
    public Vector3 prevPos, currVel;
    private Vector2 velRef;
    private int platformNum = 0;
    private float timer, actualSpeed;
    public float waitTime, speed, smoothTime;

    private bool backwards = false, playerLand, isGoing;
    private Rigidbody2D rb2d;

    // Update is called once per frame
   
    void Update()
    {
        
        {
            

            if(velRef.x < 0)
            {
                transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
            }
            else
            {
                transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
            }

            
            {
                if (positions.Length != 0)
                {
                    if(isPhysical)rb2d.velocity = (positions[platformNum].position- transform.position) * speed;
                    else
                    transform.position = Vector2.SmoothDamp(transform.position, positions[platformNum].position, ref velRef, smoothTime, speed);
                    //transform.position = Vector2.MoveTowards(transform.position, positions[platformNum].position, speed * Time.deltaTime);
                    if (!backwards)
                    {
                        if (Vector2.Distance(transform.position, positions[platformNum].position) < 1)
                        {
                            if (platformNum + 1 == positions.Length)
                            {
                                timer += Time.deltaTime;
                                if (timer > waitTime)
                                {
                                    timer = 0;
                                    backwards = true;
                                }
                            }
                            else
                            {
                                platformNum++;
                            }
                        }
                    }
                    else
                    {
                        if (Vector2.Distance(transform.position, positions[platformNum].position) < 5)
                        {
                            if (platformNum == 0)
                            {
                                timer += Time.deltaTime;
                                if (timer > waitTime)
                                {
                                    timer = 0;
                                    backwards = false;
                                    isGoing = false;
                                    playerLand = false;
                                }
                            }
                            else
                                platformNum--;
                        }
                    }
                }
            }

        }

    }

    IEnumerator CalcVelocity()
    {
        while (Application.isPlaying)
        {
            prevPos = transform.position;
            yield return new WaitForEndOfFrame();
            currVel = (prevPos - transform.position) / Time.deltaTime;
        }
    }
}
