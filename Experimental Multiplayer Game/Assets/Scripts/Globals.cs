using UnityEngine;

namespace PC2D
{
    public class Input
    {

        public const string HORIZONTAL = "Horizontal";
        public const string VERTICAL = "Vertical";
        public const string JUMP = "Jump";
        public const string DASH = "Fire1";

        public const string HORIZONTAL2 = "Horizontal2";
        public const string VERTICAL2 = "Vertical2";
        public const string JUMP2 = "Jump2";
        public const string DASH2 = "Fire2";

        public const string HORIZONTAL3 = "Horizontal3";
        public const string VERTICAL3 = "Vertical2";
        public const string JUMP3 = "Jump2";
        public const string DASH3 = "Fire2";

        public const string HORIZONTAL4 = "Horizontal4";
        public const string VERTICAL4 = "Vertical2";
        public const string JUMP4 = "Jump2";
        public const string DASH4 = "Fire2";
    }

    public class Globals
    {
        // Input threshold in order to take effect. Arbitarily set.
        public const float INPUT_THRESHOLD = 0.5f;
        public const float FAST_FALL_THRESHOLD = 0.5f;

        public const int ENV_MASK = 0x100;

        public const string PACKAGE_NAME = "PC2D";

        public const float MINIMUM_DISTANCE_CHECK = 0.01f;

        public static int GetFrameCount(float time)
        {
            float frames = time / Time.fixedDeltaTime;
            int roundedFrames = Mathf.RoundToInt(frames);

            if (Mathf.Approximately(frames, roundedFrames))
            {
                return roundedFrames;
            }

            return Mathf.CeilToInt(frames);

        }
    }
}
