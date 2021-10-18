using System;
using System.Collections.Generic;
using System.Text;

namespace _03_PhotoSearcher.Tests
{
    internal class DummyPhoto : IPhoto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Color Color { get; set; }
        public ContentType ContentType { get; set; }
    }
}
