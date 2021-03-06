using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;
using System.Collections.Generic;
using System;
using Terraria.DataStructures;
using Terraria.GameContent;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.Graphics.Shaders;

namespace eggpack.Players
{
	/// <summary>
	/// The main player without any focus on anything.
	/// </summary>
	public class EggPlayer : ModPlayer
	{
		public bool hasHellSharpener;
		public int equippedCube;

		public override void ResetEffects()
		{
			hasHellSharpener = false;
			equippedCube = 0;
		}
		public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
		{
			Random rng = new();
			if (hasHellSharpener && rng.Next(2) == 0) target.AddBuff(BuffID.OnFire, 180);
		}
	}
}