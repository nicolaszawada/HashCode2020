using PaulsBoutique.HashCode.Models;
using System;
using System.IO;

namespace PaulsBoutique.HashCode.Helpers
{
    public static class Paul
    {
        public static Boutique CreateBoutique(string path)
        {
            var boutique = new Boutique();
            using (var sr = new StreamReader(path))
            {
                bool firstLine = true;
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(' ');
                    if (firstLine)
                    {
                        // vul boutique op met info
                        boutique.NumberOfIngredients = int.Parse(line[0]);
                        boutique.NumberOfWorkers = int.Parse(line[1]);
                        // ...

                    }
                    else
                    {
                        // vul burger toe

                        var burger = new Burger();
                        burger.Prop1 = line[0];
                        burger.Prop2 = line[1];
                        burger.Prop3 = line[2];
                        burger.Prop4 = line[3];
                        burger.Prop5 = line[4];
                        burger.Prop6 = line[5];

                        boutique.Burgers.Add(burger);
                    }
                }
            }

            return boutique;
        }


        public static void CreateOutput(string fileName)
        {

            using (var sw = new StreamWriter(Path.Combine(Constants.OutputFolder, fileName + DateTime.Now.ToString("HHmm") + ".txt")))
            {
                sw.WriteLine("hallo");
            }
        }
    }
}
