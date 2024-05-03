using System.ComponentModel;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace QualityTweaks.Common.Configs
{
	//[BackgroundColor(255, 255, 255)]
	public class QualityTweaksClient : ModConfig
	{
		public static QualityTweaksClient Instance;
		public override ConfigScope Mode => ConfigScope.ClientSide;
		
		[Header("ClientOptions")]
		
		[BackgroundColor(100, 255, 0)]
		[Label("[i:HermesBoots] Walking Control")]
		[Tooltip("Hold, or Toggle walking?")]
		[DefaultValue(true)]
		public bool WalkingToggle;
	}
	public class QualityTweaksServer : ModConfig
	{
		public static QualityTweaksServer Instance;
		public override ConfigScope Mode => ConfigScope.ServerSide;
		
		[Header("ServerOptions")]
		
		[BackgroundColor(150, 150, 150)]
		[Label("[i:Wood] Stack Splitting")]
		[Tooltip("Should clients be allowed to split item stacks?")]
		[DefaultValue(true)]
		public bool StackSplittingToggle;
		
		[BackgroundColor(255, 50, 50)]
		[Label("[i:RedDye] Item Coloring")]
		[Tooltip("Should clients be allowed to apply dyes to items?")]
		[DefaultValue(true)]
		public bool ItemColoringToggle;
		
		[BackgroundColor(100, 255, 0)]
		[Label("[i:HermesBoots] Walking")]
		[Tooltip("Should clients be allowed to walk?\n(Adjust speed by scrolling the Mouse Wheel.)")]
		[DefaultValue(true)]
		public bool Walking;
		
		[BackgroundColor(0, 255, 100)]
		[Label("[i:Cog] Fix Walk Speed Bug")]
		[Tooltip("Disallows items like the Hermes Boots from activating while walking.\nDisabled by default because it has some issues.")]
		[DefaultValue(false)]
		public bool FixWalkSpeed;
		
		[BackgroundColor(100, 0, 100)]
		[Label("[i:SailfishBoots] Sprinting")]
		[Tooltip("Should clients be allowed to sprint?")]
		[DefaultValue(false)]
		public bool Sprinting;
		
		[BackgroundColor(150, 50, 50)]
		[Label("[i:TurtleShell] Slow Movement")]
		[Tooltip("Should clients have their speed reduced by 35%?")]
		[DefaultValue(false)]
		public bool SlowMovement;
	}
}
