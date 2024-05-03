using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using QualityTweaks.Common.Configs;

namespace QualityTweaks.Common.GlobalItems{
	public class ItemColoring : GlobalItem{
		public override bool InstancePerEntity => true;
		public bool isDye = (Main.mouseItem.type == ItemID.RedDye);
		public override bool CanRightClick(Item item){
			if(QualityTweaksServer.Instance.ItemColoringToggle){
				if(isDye){return true;}
			}
			return base.CanRightClick(item);
		}
		public override void RightClick(Item item, Player player){
			if(QualityTweaksServer.Instance.ItemColoringToggle){
				if(isDye){
					if(Main.mouseItem.type == ItemID.RedDye){
						item.color = Color.Red;
						//	This is only necessary because RightClick() removes 1 from the stack.
						item.stack++;
					}
				}
			}
		}
		public override void SaveData(Item item, TagCompound tag){tag.Add("Color", item.color);}
		public override void LoadData(Item item, TagCompound tag){if (tag.ContainsKey("Color")){item.color = tag.Get<Color>("Color");}}
	}
}
