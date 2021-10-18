using System;

namespace _03_PhotoSearcher
{
    public interface IPhoto
    {
        int Id { get; }
        DateTime Date { get; }
        Color Color { get; }
        ContentType ContentType { get; }
    }
}