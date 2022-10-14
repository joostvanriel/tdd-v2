using System;

namespace _04_CruiseControl
{
    public class CruiseControl
    {
        /// <summary>
        /// The cruise control system is tick based. Every 10 ms a tick is generated and Tick() is called. The Tick
        /// function checks the hardware and acts accordingly.
        /// </summary>
        public void Tick()
        {
            if (Hardware.GetInstance().IsCruiseControlOn() && Hardware.GetInstance().GetCurrentSpeed() < Hardware.GetInstance().GetCruiseControlSpeed())
            {
                Hardware.GetInstance().Accelerate(true);
            }
            else
            {
                Hardware.GetInstance().Accelerate(false);
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