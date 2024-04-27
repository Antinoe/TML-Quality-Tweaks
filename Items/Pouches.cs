using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework; //Text Colors.
using Microsoft.Xna.Framework.Input; //Allows Left Shift to be detected.

namespace QualityTweaks.Items
{
	public class CrudePouch : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityCrudePouch;
		public override string Texture => "QualityTweaks/Items/Pouch";
		public override void SetDefaults()
		{
			Item.color = Color.GhostWhite;
			base.SetDefaults();
		}

		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enableCrudePouchRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Cobweb, QualityTweaksConfigBundles.Instance.amountCrudePouch);
				if (QualityTweaksConfigBundles.Instance.enableCrudePouchRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableCrudePouchRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class SilkPouch : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacitySilkPouch;
		public override string Texture => "QualityTweaks/Items/Pouch";
		public override void SetDefaults()
		{
			Item.color = Color.SteelBlue;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enableSilkPouchRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Silk, QualityTweaksConfigBundles.Instance.amountSilkPouch);
				if (QualityTweaksConfigBundles.Instance.enableSilkPouchRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableSilkPouchRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class LeatherPouch : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityLeatherPouch;
		public override string Texture => "QualityTweaks/Items/Pouch";
		public override void SetDefaults()
		{
			Item.color = Color.Sienna;
			base.SetDefaults();
		}

		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enableLeatherPouchRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, QualityTweaksConfigBundles.Instance.amountLeatherPouch);
				if (QualityTweaksConfigBundles.Instance.enableLeatherPouchRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableLeatherPouchRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
}