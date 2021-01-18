using System;
using System.Collections.Generic;
using System.Text;

namespace facade_demo
{
    //open to the public 
    public class FacadeLayer
    {
        public Tuple<List<string>, List<string>, List<string>> GetInternalCompanyData()
        {
            //call internal services
            AuthorService authorService = new AuthorService();
            PublisherService publisherService = new PublisherService();
            TitleService titleService = new TitleService();

            return Tuple.Create(authorService.GetAuthors(), publisherService.GetPublishers(), titleService.GetTitles());
        }
    }
}
