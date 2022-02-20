using System;

namespace lab2 {
    public class MSWord : Document {

        private string Words { set; get; }

        public MSWord(string Name, string Creator, string Tags, string Theme, string Path, string words) : base(Name, Creator, Tags, Theme, Path) {
            
            Words = words;
        }

        public override void GetInfo() {

            base.GetInfo();
            Console.WriteLine($"Amount of words: {Words}");
        }
    }
}
