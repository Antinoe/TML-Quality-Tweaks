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
	public class CrudeBundle : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityCrudeBundle;
		public override string Texture => "QualityTweaks/Items/Bundle";
		public override void SetDefaults()
		{
			Item.color = Color.GhostWhite;
			base.SetDefaults();
		}

		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableCrudeBundleRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Cobweb, QualityTweaksConfigBundles.Instance.amountCrudeBundle);
				if (QualityTweaksConfigBundles.Instance.enableCrudeBundleRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableCrudeBundleRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class SilkBundle : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacitySilkBundle;
		public override string Texture => "QualityTweaks/Items/Bundle";
		public override void SetDefaults()
		{
			Item.color = Color.SteelBlue;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableSilkBundleRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Silk, QualityTweaksConfigBundles.Instance.amountSilkBundle);
				if (QualityTweaksConfigBundles.Instance.enableSilkBundleRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableSilkBundleRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class LeatherBundle : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityLeatherBundle;
		public override string Texture => "QualityTweaks/Items/Bundle";
		public override void SetDefaults()
		{
			Item.color = Color.Sienna;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableLeatherBundleRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, QualityTweaksConfigBundles.Instance.amountLeatherBundle);
				if (QualityTweaksConfigBundles.Instance.enableLeatherBundleRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableLeatherBundleRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
}