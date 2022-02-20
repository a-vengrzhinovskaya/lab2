using System;

namespace lab2 {
    public class PDF : Document {

        private string Pages { set; get; }

        public PDF(string Name, string Creator, string Tags, string Theme, string Path, string pages) : base(Name, Creator, Tags, Theme, Path) {

            Pages = pages;
        }

        public override void GetInfo() {

            base.GetInfo();
            Console.WriteLine($"Amount of pages: {Pages}");
        }
    }
}
