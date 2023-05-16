using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace QualityTweaks
{
    public class QualityTweaksHalfStackGlobalItem : GlobalItem
	{
        public override bool CanRightClick(Item item)
        {
            bool canHalfStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
            if (canHalfStack)
            {
                return true;
            }
            return false;
        }
        public override void RightClick(Item item, Player player)
        {
            bool canHalfStack = Main.mouseItem.IsAir && item.stack > 1 && Main.keyState.IsKeyDown(Keys.LeftShift);
            if (canHalfStack)
            {
                item.stack++;
                Main.mouseItem = item.Clone();
                item.stack /= 2;
                Main.mouseItem.stack -= item.stack;
            }
        }
    }
}