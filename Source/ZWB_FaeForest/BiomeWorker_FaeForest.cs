using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld.Planet;
using Verse;

namespace ZWB_LotusWilds
{
    public class BiomeWorker_FaeForest : BiomeWorker
    {

        public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }

            if(tile.rainfall < 1400f || tile.rainfall > 2600f)
            {
                return 0;
            }
            if(tile.temperature < -1f || tile.temperature > 11f)
            {
                return 0;
            }
            if(tile.swampiness > 0.5f)
            {
                return 0f;
            }
            if (tile.elevation < 300f)
            {
                return 0f;
            }


            return 16.1f + tile.temperature;
        }
    }


}