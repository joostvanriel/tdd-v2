namespace _00_Writing_a_first_unit_test
{
    public class StrangeNumber
    {
        private double value = 0.0;

        public double GetDouble()
        {
            return value;
        }

        public void SetDouble(double value)
        {
            this.value = value;
        }

        public void Add(double i)
        {
            value += i;
        }

        public void Subtract(double i)
        {
            value -= i;
        }

        public void Divide(double i)
        {
            value /= i;
        }

        public void Multiply(double i)
        {
            value *= i;
        }

    }
}
