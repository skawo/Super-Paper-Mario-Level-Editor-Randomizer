using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Paper_Mario_Randomizer.Common
{
    public class Preset
    {
        public Dictionary<int, bool> Enemies { get; set; }
        public Dictionary<int, int> ChapterDiffs { get; set; }

        public Preset()
        {
            Enemies = new Dictionary<int, bool>();
            ChapterDiffs = new Dictionary<int, int>();
        }
    }
}
