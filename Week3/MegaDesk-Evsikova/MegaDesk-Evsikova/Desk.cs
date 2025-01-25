using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Evsikova
{

    public enum DesktopMaterial
    {
        oak,
        laminate,
        pine,
        rosewood,
        veneer
    }
    internal class Desk
    {

        public const int maxwidth = 96;
        public const int minwidth = 24;
        public const int maxdepth = 48;
        public const int mindepth = 12;

        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public DesktopMaterial Material { get; set; }
    }
}
