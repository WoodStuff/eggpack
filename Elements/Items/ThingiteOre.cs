﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Eggpack;
using Terraria.GameContent.Creative;

namespace Eggpack.Elements.Items
{
	public class ThingiteOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 58;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100; 
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Elements.Tiles.Ore.ThingiteOreTile>();
			Item.width = 12;
			Item.height = 12;
			Item.value = Item.sellPrice(0, 0, 7, 50);
			Item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
			.AddRecipeGroup("SilverOre")
			.AddRecipeGroup("GoldOre")
			.AddTile(TileID.WorkBenches)
			.Register();
		}
	}
}