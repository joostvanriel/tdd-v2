using System;

namespace _04_CruiseControl
{
    public class CruiseControl
    {
        private readonly IHardware hardware;

        public CruiseControl()
        {
            hardware = Hardware.GetInstance();
        }

        public CruiseControl(IHardware hardware)
        {
            this.hardware = hardware;
        }

        /// <summary>
        /// The cruise control system is tick based. Every 10 ms a tick is generated and Tick() is called. The Tick
        /// function checks the hardware and acts accordingly.
        /// </summary>
        public void Tick()
        {
            if (hardware.IsBrakePressed() || hardware.IsClutchPressed())
            {
                hardware.DisableCruiseControl();
            }
            else if (hardware.IsCruiseControlOn() && hardware.GetCurrentSpeed() < hardware.GetCruiseControlSpeed())
            {
                hardware.Accelerate(true);
            }
            else
            {
                hardware.Accelerate(false);
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    new CruiseControl().Tick();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}