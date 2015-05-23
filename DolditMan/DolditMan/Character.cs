using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolditMan
{
    class Character
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string ChosenCharacter(string name)
        {
            string characterPath = String.Empty;
            switch(name)
            {
                default:
                case "Cartman": characterPath = "Characters/cartman.png";
                    break;
                case "Kenny": characterPath = "Characters/Kenny.png";
                    break;
                case "Kylle": characterPath = "Characters/Kylle.png";
                    break;
                case "Chef": characterPath = "Characters/Chef.png";
                    break;
                case "Stan": characterPath = "Characters/Stan.png";
                    break;
                case "Wendy": characterPath = "Characters/Wendy.png";
                    break;
            }
            return characterPath;
        }
    }
}
