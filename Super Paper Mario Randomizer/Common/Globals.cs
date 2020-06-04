using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Paper_Mario_Randomizer
{
    public static class Globals
    {
        public static List<LevelSetupEntry> LevelSetups = new List<LevelSetupEntry>();
        public static List<Enemy> EnemyList = null;
        public static string EnemyJsonPath = @"Jsons\Enemies.json";

        public static string OpenedSetupPath = "";
        public static string LoadedStagesJsonHash = "";

        public static LevelSetupEntry CurrentLevelSetupEntry;
        public static LevelSetupEntryEntry CurrentLevelSetupEntryEntry;
    }
}
