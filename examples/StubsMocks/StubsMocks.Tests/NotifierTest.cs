using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StubsMocks.Tests
{
    [TestClass]
    public class NotifierTest
    {
        private Notifier notifier;
        private Mock<IResponseHandler> responseHandler;

        [TestInitialize]
        public void SetUp()
        {
            responseHandler = new Mock<IResponseHandler>();
            notifier = new Notifier();
            notifier.Add(responseHandler.Object);
        }

        [TestMethod]
        public void PublishShouldNotifyHandler()
        {
            notifier.Publish("Some message");
            responseHandler.Verify(handler => handler.Receive("Some message"));
        }
    }
}
