using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ModLoader;
using QualityTweaks.Common.Configs;

namespace QualityTweaks.Common.GlobalItems{
	public class StackSplitting : GlobalItem{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips){
			bool canSplitStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
			if(QualityTweaksServer.Instance.StackSplittingToggle){
				if(canSplitStack){
					tooltips.Add(new(Mod, "StackSplitting", "Right-Click to split this stack in half."));
				}
			}
		}
		public override bool CanRightClick(Item item){
			bool canSplitStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
			if(QualityTweaksServer.Instance.StackSplittingToggle){
				if(canSplitStack){return true;}
			}
			return base.CanRightClick(item);
		}
		public override void RightClick(Item item, Player player){
			bool canSplitStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
			if(QualityTweaksServer.Instance.StackSplittingToggle){
				if(canSplitStack){
					item.stack++;
					Main.mouseItem = item.Clone();
					item.stack /= 2;
					Main.mouseItem.stack -= item.stack;
				}
			}
		}
	}
	//	Putting these here so I don't forget about them.
    public class InsertOneFromStack : GlobalItem{
		//	With item stack in-hand, RightClick an empty slot to insert one item from the stack into that slot.
	}
    public class DragStack : GlobalItem{
		//	With item stack in-hand, hold RightClick while dragging across inventory slots to insert items from the stack into each one.
	}
}
