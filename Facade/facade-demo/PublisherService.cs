using System;
using System.Collections.Generic;

namespace facade_demo
{
    public class PublisherService
    {
        public List<string> GetPublishers()
        {
            return new List<string>()
            {
                "publisher 1",
                "publisher 2",
                "publisher 3"
            };
        }
    }
}
