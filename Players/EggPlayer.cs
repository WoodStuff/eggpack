using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Eggpack.Players
{
	/// <summary>
	/// The main player without any focus on anything.
	/// </summary>
	public class EggPlayer : ModPlayer
	{
		public bool hasHellSharpener;
		public int equippedCube;
		public int equippedCubePrefix;

		public override void ResetEffects()
		{
			hasHellSharpener = false;
			equippedCube = 0;
			equippedCubePrefix = 0;
		}
		public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
		{
			Random rng = new();
			if (hasHellSharpener && rng.Next(2) == 0) target.AddBuff(BuffID.OnFire, 180);
		}
	}
}