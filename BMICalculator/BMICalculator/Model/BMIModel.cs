namespace BMICalculator.Model
{
    class BMIModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }

        public double CalculateBMI()
        {
            double bmi = Weight / (Height * Height);
            return bmi;
        }

    }
}
