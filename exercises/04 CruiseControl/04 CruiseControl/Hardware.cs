using System;

namespace _04_CruiseControl
{
    class Hardware
    {
        private static Hardware _instance = null;

        private Hardware()
        {
        }

        public static Hardware GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Hardware();
            }

            return _instance;
        }

        public void Accelerate(bool accelerate)
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public int GetCurrentSpeed()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public bool IsBrakePressed()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public bool IsClutchPressed()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public bool IsCruiseControlOn()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public void DisableCruiseControl()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }

        public int GetCruiseControlSpeed()
        {
            // Don't change the body of this method. Consider this method containing logic for actually controlling the hardware.
            throw new Exception("No connection to real car");
        }
    }
}
