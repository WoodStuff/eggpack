﻿/*using Terraria;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using Terraria.GameContent.Generation;
using eggpack.Elements.Tiles.Ore;
using System.Collections.Generic;
using Terraria.IO;

namespace eggpack
{
	class ModWorldGen : ModSystem
	{
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Egg Ores", GenOres));
			}
		}

		private void GenOres(GenerationProgress progress, GameConfiguration config)
		{
			progress.Message = "Thingifying the world";

			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 0.00015); k++)
			{
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

				WorldGen.TileRunner(x - 1, y, WorldGen.genRand.Next(4, 7), WorldGen.genRand.Next(1, 2), ModContent.TileType<ThingiteOreTile>());
			}
		}
	}
}*/