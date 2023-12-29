using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Authors
{
    public class GetAuthorListDto
    {
        public string? Filter { get; set; }
        public string Sorting { get; set; }
        public int MaxResultCount { get; set; }
        public int SkipCount { get; set; }
    }
}
