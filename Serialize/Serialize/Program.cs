using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialize
{
    public class Cereal
    {
        public string name { get; set; }
        public string slogan { get; set; }
        public Boolean clarkeApproved { get; set; }
        public int calories { get; set; }
        public decimal price { get; set; }
        public string picture { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cereal luckyCharms = new Cereal();
            luckyCharms.name = "Lucky Charms";
            luckyCharms.slogan = "They're magically delicious!";
            luckyCharms.clarkeApproved = true;
            luckyCharms.calories = 1;
            luckyCharms.price = 15.37M;

            Cereal frostedMiniWheats = new Cereal();
            frostedMiniWheats.name = "Frosted Mini Wheats";
            frostedMiniWheats.slogan = "Keeps them full. Keeps them focused";
            frostedMiniWheats.clarkeApproved = true;
            frostedMiniWheats.calories = 2;
            frostedMiniWheats.price = 7.76M;

            Cereal frootLoops = new Cereal();
            frootLoops.name = "Froot Loops";
            frootLoops.slogan = "Whatever fruits your loops";
            frootLoops.clarkeApproved = false;
            frootLoops.calories = 3;
            frootLoops.price = 13.65M;

            string jsonString = JsonSerializer.Serialize(frostedMiniWheats);
            Console.WriteLine(jsonString);
            Console.ReadKey();
        }
    }
}
