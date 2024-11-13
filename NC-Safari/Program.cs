using System.Globalization;

namespace NC_Safari
{
    internal class Program
    {
        public static void Main()
        {
            Tiger fluffy = new Tiger(80);
            Penguin penny = new Penguin(20.4f);
            Goose jeff = new Goose(3);
            Bat betty = new Bat(0.7f);

            //HuntingGround huntingGround = new HuntingGround();

            //huntingGround.AddAnimalInEnvironment(fluffy);
            //huntingGround.AddAnimalInEnvironment(penny);
            //huntingGround.AddAnimalInEnvironment(betty);

            //huntingGround.CheckAnimalsInEnvironment();

            //WeightComparer weightComparer = new WeightComparer(false);
            //List<Animal> animalsToSee = new List<Animal>
            //{
            //  new Tiger(70),
            //  new Goose(5.2f),
            //  new Bat(0.9f),
            //  new Goose(4),
            //  new Tiger(90),
            //  new Penguin(15.8f)
            //};
            //animalsToSee.Sort(weightComparer);

            //animalsToSee.ForEach(animal => Console.WriteLine($" {animal.GetType().Name} - {animal.Weight}kg"));

            WeightFormatter tigerWeigher = new WeightFormatter(new Tiger(100.4f));

            Console.WriteLine(tigerWeigher.ToString("kilograms", CultureInfo.CurrentCulture));
            Console.WriteLine(tigerWeigher.ToString("kilograms", new CultureInfo("de-DE")));

            Console.WriteLine(tigerWeigher.ToString("ounces", CultureInfo.CurrentCulture));
            Console.WriteLine(tigerWeigher.ToString("ounces", new CultureInfo("de-DE")));
        }
    }
}
