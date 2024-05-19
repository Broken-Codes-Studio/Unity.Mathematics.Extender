namespace Unity.Mathematics.Extender
{
    public static partial class math
    {
        public static float GetClosestNumber(float value, float step)
        {
            // Get the absolute values of our arguments
            var absValue = Mathematics.math.abs(value);
            step = Mathematics.math.abs(step);

            // Determing the numbers on either side of value
            var low = absValue - absValue % step;
            var high = low + step;

            // Return the closest one, multiplied by -1 if value < 0
            var result = absValue - low < high - absValue ? low : high;
            return result * Mathematics.math.sign(value);
        }
    }
}
