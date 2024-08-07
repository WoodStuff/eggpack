﻿using Eggpack.Elements.Buffs;
using Eggpack.Elements.Items;
using Eggpack.Elements.Projectiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Eggpack.Elements.Cubes
{
	public class ThingiteCube : Cube
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void CustomDefaults()
		{
			Item.value = Item.sellPrice(0, 1, 0, 0);
			Item.rare = ItemRarityID.Blue;
		}
		public override CubeSettings GetCubeSettings()
		{
			CubeSettings settings = new()
			{
				cooldown = Eggpack.ToFrames(20),
				manaCost = 40,
				projectileID = ModContent.ProjectileType<ThingiteBurst>(),
				projectileSpeed = 10,
				damages = true,
				backfireBuffID = ModContent.BuffType<WeaponExhaustion>(),
				backfireBuffDuration = Eggpack.ToFrames(10),
			};

			return settings;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<ThingiteBar>(10)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}