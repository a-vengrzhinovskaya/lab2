using System;

namespace lab2 {
    public class DocumentSingleton {

        private static DocumentSingleton instance;

        private DocumentSingleton() {

        }

        public static DocumentSingleton GetInstance() {

            if (instance == null) {

                instance = new DocumentSingleton();
            }

            return instance;
        }

        private void SetBaseInfo(out string name, out string creator, out string tags, out string theme, out string path) {

            Console.Clear();

            Console.WriteLine("Enter document name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter creator's name: ");
            creator = Console.ReadLine();

            Console.WriteLine("Enter tags: ");
            tags = Console.ReadLine();

            Console.WriteLine("Enter theme: ");
            theme = Console.ReadLine();

            Console.WriteLine("Enter path: ");
            path = Console.ReadLine();
        }

        private void MSWordInfo() {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Enter amount of words:");
            var Words = Console.ReadLine();

            Console.Clear();

            var Doc = new MSWord(Name, Creator, Tags, Theme, Path, Words);

            Console.WriteLine("Document type: MS Word" + "\n");

            Doc.GetInfo();
        }

        private void PDFInfo() {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Enter amount of pages:");
            var Pages = Console.ReadLine();

            Console.Clear();

            var Doc = new PDF(Name, Creator, Tags, Theme, Path, Pages);

            Console.WriteLine("Document type: PDF" + "\n");

            Doc.GetInfo();
        }

        private void MSExcelInfo() {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Enter amount of columns:");
            var Columns = Console.ReadLine();

            Console.WriteLine("Enter amount of rows:");
            var Rows = Console.ReadLine();

            Console.Clear();

            var Doc = new MSExcel(Name, Creator, Tags, Theme, Path, Columns, Rows);

            Console.WriteLine("Document type: MS Excel" + "\n");

            Doc.GetInfo();
        }

        private void TXTInfo() {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Enter amount of words:");
            var Words = Console.ReadLine();

            Console.WriteLine("Enter amount of lines:");
            var Lines = Console.ReadLine();

            Console.Clear();

            var Doc = new TXT(Name, Creator, Tags, Theme, Path, Words, Lines);

            Console.WriteLine("Document type: TXT" + "\n");

            Doc.GetInfo();
        }

        private void HTMLInfo() {

            string Name, Creator, Tags, Theme, Path;

            SetBaseInfo(out Name, out Creator, out Tags, out Theme, out Path);

            Console.WriteLine("Enter link:");
            var Link = Console.ReadLine();

            Console.Clear();

            var Doc = new HTML(Name, Creator, Tags, Theme, Path, Link);

            Console.WriteLine("Document type: HTML" + "\n");

            Doc.GetInfo();
        }

        public void Menu() {

            Console.WriteLine("Select document type:" + "\n");
            Console.WriteLine("MS Word      0");
            Console.WriteLine("PDF          1");
            Console.WriteLine("MS Excel     2");
            Console.WriteLine("TXT          3");
            Console.WriteLine("HTML         4");

            var Option = Console.ReadLine();

            switch (Option) {

                case "0":

                    MSWordInfo();

                    break;

                case "1":

                    PDFInfo();

                    break;

                case "2":

                    MSExcelInfo();

                    break;

                case "3":

                    TXTInfo();

                    break;

                case "4":

                    HTMLInfo();

                    break;

                default:

                    Console.WriteLine("\n" + "Unknown type.");

                    break;
            }

            Console.ReadKey();
        }
    }
}
