using System.Collections.Generic;

namespace facade_demo
{
    public class TitleService
    {
        public List<string> GetTitles()
        {
            return new List<string>()
            {
                "title 1",
                "title 2",
                "title 3"
            };
        }
    }
}
