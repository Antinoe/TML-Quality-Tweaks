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
	public class PocketCase : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityPocketCase;
		public override string Texture => "QualityTweaks/Items/PocketCase";
		public override void SetDefaults()
		{
			Item.color = Color.BurlyWood;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enablePocketCaseRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddRecipeGroup(RecipeGroupID.Wood, QualityTweaksConfigBundles.Instance.amountPocketCase);
				if (QualityTweaksConfigBundles.Instance.enablePocketCaseRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				Bundle.Register();
			}
		}
	}
	public class ApparelCase : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityApparelCase;
		protected override bool ValidContainedItem(Item item)
        {
			return item.defense > 0 || item.accessory || item.vanity;
		}

		public override string Texture => "QualityTweaks/Items/ApparelCase";
		public override void SetDefaults()
		{
			Item.color = Color.BurlyWood;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enableApparelCaseRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddRecipeGroup(RecipeGroupID.Wood, QualityTweaksConfigBundles.Instance.amountApparelCaseWood);
				Bundle.AddIngredient(ItemID.Leather, QualityTweaksConfigBundles.Instance.amountApparelCaseLeather);
				if (QualityTweaksConfigBundles.Instance.enableApparelCaseRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableApparelCaseRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class DoubleScabbard : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityDoubleScabbard;
		protected override bool ValidContainedItem(Item item)
		{
			return item.maxStack == 1 && item.damage > 0;
		}

		public override string Texture => "QualityTweaks/Items/DoubleScabbard";
		public override void SetDefaults()
		{
			Item.color = Color.Peru;
			base.SetDefaults();
		}
		
		public override void AddRecipes()
		{
			if (QualityTweaksConfigBundles.Instance.enableMaster && QualityTweaksConfigBundles.Instance.enableDoubleScabbardRecipe)
			{
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, QualityTweaksConfigBundles.Instance.amountDoubleScabbard);
				if (QualityTweaksConfigBundles.Instance.enableDoubleScabbardRecipeWorkBench)
				{
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (QualityTweaksConfigBundles.Instance.enableDoubleScabbardRecipeLoom)
				{
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class CheatBundle : BaseBundle
	{
		protected override int maxCapacity() => QualityTweaksConfigBundles.Instance.capacityCheatBundle;
		public override void SetDefaults()
		{
			Item.color = Color.Magenta;
			base.SetDefaults();
		}
	}
}