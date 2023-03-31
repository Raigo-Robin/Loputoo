namespace Lõputöö___Raigo_Robin_Anni__TITge22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali meetod:\n1 - Where\n2 - Skip\n3 - Sum\n4 - SkipWhile\n5 - FileMaker\n6 - Püramiid");
            Console.Write("\n");

            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    WhereLINQ();
                    break;

                case 2:
                    SkipLINQ();
                    break;

                case 3:
                    SumLINQ();
                    break;

                case 4:
                    SkipWhile();
                    break;
                
                case 5:
                    FileMaker();
                    break;
               
                case 6:
                    ForLoop();
                    break;

            }

        }

        public static void WhereLINQ()
        {
            Console.WriteLine("Where LINQ: ");
            Console.WriteLine("Näitab nimekirja üleühe: \n");
            var filtered = CarList.cars.Where((s, i) =>
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            foreach (var cars in filtered)
            {
                Console.WriteLine("Name: " + cars.Name + ", Id: " + cars.Id + ", Year: " + cars.Year + ", Vanus: " + cars.Age);
            }
        }

        public static void SkipLINQ()
        {
            Console.WriteLine("Skipib 3 esimest: ");
            var skip = CarList.cars.Skip(3);

            foreach (var cars in skip)
            {
                Console.WriteLine("Name: " + cars.Name + ", Id: " + cars.Id + ", Year: " + cars.Year + ", Vanus: " + cars.Age);
            }
        }

        public static void SumLINQ()
        {
            Console.WriteLine("Liidame auto vanused kokku: ");

            var sumAge = CarList.cars
                .Sum(x => x.Age);
            Console.WriteLine("Auto vanused kokku liidetud: " + sumAge);
        }

        public static void SkipWhile()
        {
            var skipWhile = CarList.cars.SkipWhile(x => x.Age < 13);

            foreach (var car in skipWhile)
            {
                Console.WriteLine(skipWhile);
            }
        }

        public static void FileMaker()
        {
            try
            {
                Console.WriteLine("Enter the file name:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Enter the path:");
                string path = Console.ReadLine();

                if (Directory.Exists(path))
                {
                    string fullPath = Path.Combine(path, fileName);

                    if (!File.Exists(fullPath))
                    {
                        using (StreamWriter sw = File.CreateText(fullPath))
                        {
                            Console.WriteLine("Enter the text to write to the file:");
                            string text = Console.ReadLine();
                            sw.Write(text);
                        }
                        Console.WriteLine("File created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("File already exists at the specified path.");
                    }
                }
                else
                {
                    throw new DirectoryNotFoundException("The specified path does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void ForLoop()
        {
            int i, j, spc, rows, k, t = 1;
            Console.Write("input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }
        }
    }
}