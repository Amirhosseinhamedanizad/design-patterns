using System;
using System.Collections.Generic;

namespace facade_demo
{
    public class AuthorService
    {
        public  List<string> GetAuthors()
        {
            return new List<string>()
            {
                "author 1",
                "author 2",
                "author 3"
            };
        }
    }
}
