using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Employee
    {
        private string name = "";
        private string surname = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public static void Salarry()
        {
            Console.WriteLine("Choose a position as a Geographer, Historian, Biologist");
            string job = Console.ReadLine();
            Console.WriteLine("work experience in years:");
            int experience = int.Parse(Console.ReadLine());
            int g = 12000;
            int h = 13000;
            int b = 16000;
            switch (job)
            {
                case "Geographer":
                    {
                        Console.WriteLine("you have chosen the profession of a Geographer");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {g + 700}");
                            Console.WriteLine($"tax fee:{((g + 700) / 100) * 22}");

                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {g + 3200}");
                            Console.WriteLine($"tax fee:{((g + 3200) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {g + 6000}");
                            Console.WriteLine($"tax fee:{((g + 6000) / 100) * 22}");
                        }
                    }
                    break;
                case "Historian":
                    {
                        Console.WriteLine("you have chosen the profession of a Historian");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {h + 300}");
                            Console.WriteLine($"tax fee:{((h + 300) / 100) * 22}");

                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {h + 1400}");
                            Console.WriteLine($"tax fee:{((h + 1400) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {h + 4900}");
                            Console.WriteLine($"tax fee:{((h + 4900) / 100) * 22}");
                        }
                    }
                    break;
                case "Biologist":
                    {
                        Console.WriteLine("you have chosen the profession of a Biologist");
                        if (experience <= 5)
                        {
                            Console.WriteLine($"Salarry {b + 400}");
                            Console.WriteLine($"tax fee:{((b + 400) / 100) * 22}");
                        }
                        else if (experience > 5 && experience <= 10)
                        {
                            Console.WriteLine($"Salarry {b + 2000}");
                            Console.WriteLine($"tax fee:{((b + 2000) / 100) * 22}");
                        }
                        else if (experience > 10 && experience <= 100)
                        {
                            Console.WriteLine($"Salarry {b + 8000}");
                            Console.WriteLine($"tax fee:{((b + 8000) / 100) * 22}");
                        }
                    }
                    break;

            }
        }
    }
}
