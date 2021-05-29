using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day7.WorlOfTanks
{
    class Tank
    {

        public Tank(string name)
        {
            Name = name;
            Random rnd = new Random();
            LevelOfAmmunition = rnd.Next(0, 100);
            LevelOfArmor = rnd.Next(0, 100);
            LevelOfManeuverability = rnd.Next(0, 100);
            Thread.Sleep(100);
        }

        public string Name { get; set; }
        public int LevelOfAmmunition { get; set; }
        public int LevelOfArmor { get; set; }
        public int LevelOfManeuverability { get; set; }
        public static string operator *(Tank t1, Tank t2)
        {
            string winner = "Winner is ";
            if ((t1.LevelOfAmmunition > t2.LevelOfAmmunition) && (t1.LevelOfArmor > t2.LevelOfArmor)) { winner += $"{t1.Name}"; }
            else if ((t1.LevelOfAmmunition > t2.LevelOfAmmunition) && (t1.LevelOfManeuverability > t2.LevelOfManeuverability)) { winner += $"{t1.Name}"; }
            else if ((t1.LevelOfArmor > t2.LevelOfArmor) && (t1.LevelOfManeuverability > t2.LevelOfManeuverability)) { winner += $"{t1.Name}"; }
            else if ((t1.LevelOfAmmunition < t2.LevelOfAmmunition) && (t1.LevelOfArmor < t2.LevelOfArmor)) { winner += $"{t2.Name}"; }
            else if ((t1.LevelOfAmmunition < t2.LevelOfAmmunition) && (t1.LevelOfManeuverability < t2.LevelOfManeuverability)) { winner += $"{t2.Name}"; }
            else if ((t1.LevelOfArmor < t2.LevelOfArmor) && (t1.LevelOfManeuverability < t2.LevelOfManeuverability)) { winner += $"{t2.Name}"; }



            return winner;
        }
        public override string ToString()
        {
            return $"Name: {Name}  LevelOfAmmunition: {LevelOfAmmunition} LevelofArmor: {LevelOfArmor} LevelOfManeuverability: {LevelOfManeuverability}";
        }

    }
}
