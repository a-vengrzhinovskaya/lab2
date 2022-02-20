using System;

namespace lab2 {
    public class MSExcel : Document {

        private string Columns { set; get; }
        private string Rows { set; get; }

        public MSExcel(string Name, string Creator, string Tags, string Theme, string Path, string columns, string rows) : base(Name, Creator, Tags, Theme, Path) {

            Columns = columns;
            Rows = rows;
        }

        public override void GetInfo() {

            base.GetInfo();
            Console.WriteLine($"Amount of columns: {Columns}");
            Console.WriteLine($"Amount of rows: {Rows}");
        }
    }
}
