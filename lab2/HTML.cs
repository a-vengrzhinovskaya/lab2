using System;

namespace lab2 {
    public class HTML : Document {

        private string Link { set; get; }

        public HTML(string Name, string Creator, string Tags, string Theme, string Path, string link) : base(Name, Creator, Tags, Theme, Path) {

            Link = link;
        }

        public override void GetInfo() {

            base.GetInfo();
            Console.WriteLine($"Link: {Link}");
        }
    }
}
