using System.Text.Json;

namespace CSharpTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Earning[] earnings =
            {
                new Earning("AMD",new DateOnly(2023, 06, 01), 2.57),
                new Earning("AMD", new DateOnly(2023, 09, 01), 2.44),
                new Earning("AMD",new DateOnly(2024, 01, 01), 3.16),
                new Earning("AMD", new DateOnly(2024, 04, 01), 4.20),
            };

            string path = @"C:\Users\izzew\source\repos\CSharpTraining\CSharpTraining\earnings.json";

            ReadAndWriteJson(earnings, path);




            static void ReadAndWriteJson(Earning[] earnings, string path)
            {
                File.WriteAllText(
                    path,
                    JsonSerializer.Serialize(earnings));

                string textFromFile = File.ReadAllText(path);

                Earning[]? earningsFromJson = JsonSerializer.Deserialize<Earning[]>(textFromFile);

                Console.WriteLine(earningsFromJson[0].Eps);
            }
        }
    }
}