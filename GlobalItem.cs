using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace QualityTweaks
{
    public class QualityTweaksSplitStack : GlobalItem
	{
        public override bool CanRightClick(Item item)
        {
            bool canSplitStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
            if (canSplitStack)
            {
                return true;
            }
            return false;
        }
        public override void RightClick(Item item, Player player)
        {
            bool canSplitStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
            if (canSplitStack)
            {
                item.stack++;
                Main.mouseItem = item.Clone();
                item.stack /= 2;
                Main.mouseItem.stack -= item.stack;
            }
        }
    }
    public class QualityTweaksInsertOneFromStack : GlobalItem
    {
        //  With item stack in-hand, RightClick an empty slot to insert one item from the stack into that slot.
    }
    public class QualityTweaksDragStack : GlobalItem
    {
        //  With item stack in-hand, hold RightClick while dragging across inventory slots to insert items from the stack into each one.
    }
    public class QualityTweaksColoringGlobalItem : GlobalItem
	{
        public override bool CanRightClick(Item item)
        {
            if (Main.mouseItem.type == ItemID.RedDye)
            {
                return true;
            }
            return false;
        }
        public override void RightClick(Item item, Player player)
        {
            var heldItem = Main.mouseItem;
            if (heldItem.type == ItemID.RedDye)
            {
                item.color = Color.Red;
                item.stack++;
            }
        }

        public override void SaveData(Item item, TagCompound tag)
        {
			tag.Add("Color", item.color);
		}
        public override void LoadData(Item item, TagCompound tag)
		{
            if (tag.ContainsKey("Color"))
            {
                item.color = tag.Get<Color>("Color");
            }
		}
    }
}