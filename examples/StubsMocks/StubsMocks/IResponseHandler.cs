namespace StubsMocks
{
    public interface IResponseHandler
    {
        void Receive(string message);
        string Name { get; }
    }
}
