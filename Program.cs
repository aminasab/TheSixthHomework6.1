namespace TheSixthProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var venus = new { Name = "Венера", SerialNumberFromTheSun = 2, LenghtOfEquator = 38_025, PreviousPlanet = "Солнце" };
            var earth = new { Name = "Земля", SerialNumberFromTheSun = 3, LenghtOfEquator = 40_075, PreviousPlanet = venus.Name };
            var mars = new { Name = "Марс", SerialNumberFromTheSun = 4, LenghtOfEquator = 21_344, PreviousPlanet = earth.Name };
            var newVenus = venus;

            Console.WriteLine($"{venus.Name}: Порядковый номер от Солнца-{venus.SerialNumberFromTheSun}, Длина экватора-{venus.LenghtOfEquator} Предыдущая планета- {venus.PreviousPlanet}");
            Console.Write($"{earth.Name}: Порядковый номер от Солнца-{earth.SerialNumberFromTheSun}, Длина экватора-{earth.LenghtOfEquator} Предыдущая планета- {earth.PreviousPlanet}");
            Console.WriteLine(earth == venus ? " -Эквивалентна Венере" : " -Не эквивалентна Венере");
            Console.Write($"{mars.Name}: Порядковый номер от Солнца-{mars.SerialNumberFromTheSun} , Длина экватора-{mars.LenghtOfEquator} Предыдущая планета- {mars.PreviousPlanet}");
            Console.WriteLine(mars == venus ? " -Эквивалентна Венере" : " -Не эквивалентна Венере");
            Console.Write($"{newVenus.Name}: Порядковый номер от Солнца-{newVenus.SerialNumberFromTheSun} , Длина экватора-{newVenus.LenghtOfEquator} Предыдущая планета- {newVenus.PreviousPlanet}");
            Console.WriteLine(newVenus == venus ? " -Эквивалентна Венере" : " -Не эквивалентна Венере");
        }
    }
}
