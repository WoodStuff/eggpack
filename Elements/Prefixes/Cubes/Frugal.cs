﻿using Terraria.ModLoader;
using eggpack.Elements;
using Terraria;

namespace eggpack.Elements.Prefixes.Cubes
{
	/// <summary>
	/// A neutral cube prefix.
	/// </summary>
	public class Frugal : CubePrefix
	{
		public override CubePrefixModifiers GetModifiedStats()
		{
			return new()
			{
				manaCost = 0.75f,
				cooldown = 1.1f
			};
		}
		public override void ModifyValue(ref float valueMult)
		{
			valueMult *= 1.35f;
		}
		public override void SetStaticDefaults()
		{
			Cube.CubePrefixes.Add(Type);
		}
	}
}