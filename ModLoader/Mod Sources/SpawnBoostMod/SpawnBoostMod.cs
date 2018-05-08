using Terraria;
using Terraria.ModLoader;

namespace SpawnBoostMod
{
    class SpawnBoostMod : Mod
    {
        public SpawnBoostMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }
    }

    class SpawnRateMultiplierGlobalNPC : GlobalNPC
    {
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            spawnRate = (int) 3;
            maxSpawns = (int) 400;
        }
    }
}