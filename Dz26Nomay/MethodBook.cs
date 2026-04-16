using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz26Nomay
{
    public class MethodBook
    {
        private string title;
        private string author;
        private int year;
        private int pages;
        private string publisher = "Просвещение";

        public MethodBook(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        public string GetTitle() => title;
        public void SetTitle(string value) => title = value;

        public string GetAuthor() => author;
        public int GetYear() => year;
        public int GetPages() => pages;
        public string GetPublisher() => publisher;

        public string GetInformation() =>
            $"[Methods] '{title}', {author} ({year} г.), {pages} стр. Изд: {publisher}";
    }
}
