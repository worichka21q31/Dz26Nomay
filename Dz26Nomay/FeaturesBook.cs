using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class FeaturesBook
    {
        private string _title;
        private readonly string _author;

        public int Year { get; set; }
        public int Pages { get; set; }

        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string Author => _author;

        public string Publisher { get; private set; } = "Наука";

        public string Information =>
            $"[Features] '{Title}', {Author} ({Year} г.), {Pages} стр. Изд: {Publisher}";

        public FeaturesBook(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }
    }
}
