using System;

namespace lab2 {

    public abstract class Document {

        private string Name { get; set; }
        private string Creator { get; set; }
        private string Tags { get; set; }
        private string Theme { get; set; }
        private string Path { get; set; }

        public Document(string name, string creator, string tags, string theme, string path) {

            Name = name;
            Creator = creator;
            Tags = tags;
            Theme = theme;
            Path = path;
        }

        public virtual void GetInfo() {

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Creator: {Creator}");
            Console.WriteLine($"Tags: {Tags}");
            Console.WriteLine($"Theme: {Theme}");
            Console.WriteLine($"Path: {Path}");
        }
    }
}

