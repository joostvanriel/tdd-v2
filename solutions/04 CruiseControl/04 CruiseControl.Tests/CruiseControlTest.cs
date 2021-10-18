using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _04_CruiseControl.Tests
{
    [TestClass]
    public class CruiseControlTest
    {
        private Mock<IHardware> hardwareMock;
        private CruiseControl cruiseControl;

        [TestInitialize]
        public void SetUp()
        {
            hardwareMock = new Mock<IHardware>();
            cruiseControl = new CruiseControl(hardwareMock.Object);
        }

        [TestMethod]
        public void Tick_CruiseControlIsOnAndSpeedIsLowerThanTargetSpeed_Accelerates()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(true);
            hardwareMock.Setup(h => h.GetCurrentSpeed()).Returns(49);
            hardwareMock.Setup(h => h.GetCruiseControlSpeed()).Returns(50);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.Accelerate(true));
        }

        [TestMethod]
        public void Tick_CruiseControlIsOnAndSpeedIsSameAsTargetSpeed_DoesNotAccelerate()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(true);
            hardwareMock.Setup(h => h.GetCurrentSpeed()).Returns(50);
            hardwareMock.Setup(h => h.GetCruiseControlSpeed()).Returns(50);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.Accelerate(false));
        }

        [TestMethod]
        public void Tick_CruiseControlIsOnAndSpeedIsHigherThanTargetSpeed_DoesNotAccelerate()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(true);
            hardwareMock.Setup(h => h.GetCurrentSpeed()).Returns(51);
            hardwareMock.Setup(h => h.GetCruiseControlSpeed()).Returns(50);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.Accelerate(false));
        }

        [TestMethod]
        public void Tick_CruiseControlIsOffAndSpeedIsLowerThanTargetSpeed_DoesNotAccelerate()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(false);
            hardwareMock.Setup(h => h.GetCurrentSpeed()).Returns(49);
            hardwareMock.Setup(h => h.GetCruiseControlSpeed()).Returns(50);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.Accelerate(false));
        }

        [TestMethod]
        public void Tick_BrakeIsPressed_SwitchesCruiseControlOff()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(true);
            hardwareMock.Setup(h => h.IsBrakePressed()).Returns(true);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.DisableCruiseControl());
        }

        [TestMethod]
        public void Tick_ClutchIsPressed_SwitchesCruiseControlOff()
        {
            // arrange
            hardwareMock.Setup(h => h.IsCruiseControlOn()).Returns(true);
            hardwareMock.Setup(h => h.IsClutchPressed()).Returns(true);

            // act
            cruiseControl.Tick();

            // assert
            hardwareMock.Verify(h => h.DisableCruiseControl());
        }
    }
}
