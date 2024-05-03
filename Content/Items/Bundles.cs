using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using QualityTweaks.Common.Configs;

namespace QualityTweaks.Content.Items{
	public class CrudeBundle : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityCrudeBundle;
		public override string Texture => "QualityTweaks/Content/Items/Bundle";
		public override void SetDefaults(){
			Item.color = Color.GhostWhite;
			base.SetDefaults();
		}

		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableCrudeBundleRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Cobweb, BundlesConfig.Instance.amountCrudeBundle);
				if (BundlesConfig.Instance.enableCrudeBundleRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableCrudeBundleRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class SilkBundle : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacitySilkBundle;
		public override string Texture => "QualityTweaks/Content/Items/Bundle";
		public override void SetDefaults(){
			Item.color = Color.SteelBlue;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableSilkBundleRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Silk, BundlesConfig.Instance.amountSilkBundle);
				if (BundlesConfig.Instance.enableSilkBundleRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableSilkBundleRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class LeatherBundle : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityLeatherBundle;
		public override string Texture => "QualityTweaks/Content/Items/Bundle";
		public override void SetDefaults(){
			Item.color = Color.Sienna;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableLeatherBundleRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, BundlesConfig.Instance.amountLeatherBundle);
				if (BundlesConfig.Instance.enableLeatherBundleRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableLeatherBundleRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class CrudePouch : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityCrudePouch;
		public override string Texture => "QualityTweaks/Content/Items/Pouch";
		public override void SetDefaults(){
			Item.color = Color.GhostWhite;
			base.SetDefaults();
		}

		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableCrudePouchRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Cobweb, BundlesConfig.Instance.amountCrudePouch);
				if (BundlesConfig.Instance.enableCrudePouchRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableCrudePouchRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class SilkPouch : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacitySilkPouch;
		public override string Texture => "QualityTweaks/Content/Items/Pouch";
		public override void SetDefaults(){
			Item.color = Color.SteelBlue;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableSilkPouchRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Silk, BundlesConfig.Instance.amountSilkPouch);
				if (BundlesConfig.Instance.enableSilkPouchRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableSilkPouchRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class LeatherPouch : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityLeatherPouch;
		public override string Texture => "QualityTweaks/Content/Items/Pouch";
		public override void SetDefaults(){
			Item.color = Color.Sienna;
			base.SetDefaults();
		}

		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableLeatherPouchRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, BundlesConfig.Instance.amountLeatherPouch);
				if (BundlesConfig.Instance.enableLeatherPouchRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableLeatherPouchRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class PocketCase : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityPocketCase;
		public override string Texture => "QualityTweaks/Content/Items/PocketCase";
		public override void SetDefaults(){
			Item.color = Color.BurlyWood;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enablePocketCaseRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddRecipeGroup(RecipeGroupID.Wood, BundlesConfig.Instance.amountPocketCase);
				if (BundlesConfig.Instance.enablePocketCaseRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				Bundle.Register();
			}
		}
	}
	public class ApparelCase : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityApparelCase;
		protected override bool ValidContainedItem(Item item)
        {
			return item.defense > 0 || item.accessory || item.vanity;
		}

		public override string Texture => "QualityTweaks/Content/Items/ApparelCase";
		public override void SetDefaults(){
			Item.color = Color.BurlyWood;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableApparelCaseRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddRecipeGroup(RecipeGroupID.Wood, BundlesConfig.Instance.amountApparelCaseWood);
				Bundle.AddIngredient(ItemID.Leather, BundlesConfig.Instance.amountApparelCaseLeather);
				if (BundlesConfig.Instance.enableApparelCaseRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableApparelCaseRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class DoubleScabbard : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityDoubleScabbard;
		protected override bool ValidContainedItem(Item item){
			return item.maxStack == 1 && item.damage > 0;
		}

		public override string Texture => "QualityTweaks/Content/Items/DoubleScabbard";
		public override void SetDefaults(){
			Item.color = Color.Peru;
			base.SetDefaults();
		}
		
		public override void AddRecipes(){
			if (BundlesConfig.Instance.enableMaster && BundlesConfig.Instance.enableDoubleScabbardRecipe){
				Recipe Bundle = CreateRecipe(1);
				Bundle.AddIngredient(ItemID.Leather, BundlesConfig.Instance.amountDoubleScabbard);
				if (BundlesConfig.Instance.enableDoubleScabbardRecipeWorkBench){
					Bundle.AddTile(TileID.WorkBenches);
				}
				if (BundlesConfig.Instance.enableDoubleScabbardRecipeLoom){
					Bundle.AddTile(TileID.Loom);
				}
				Bundle.Register();
			}
		}
	}
	public class CheatBundle : BaseBundle{
		protected override int maxCapacity() => BundlesConfig.Instance.capacityCheatBundle;
		public override void SetDefaults(){
			Item.color = Color.Magenta;
			base.SetDefaults();
		}
	}
}
