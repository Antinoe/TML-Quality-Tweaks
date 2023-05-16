using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace QualityTweaks
{
    [Label("Server Config")]
    public class QualityTweaksConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static QualityTweaksConfigServer Instance;
		
	[Header("General")]
		
        [Label("[i:Wood] Enable Stack Splitting?")]
        [Tooltip("If true, players can grab half of an item stack by Shift+RightClicking.")]
        [DefaultValue(true)]
        public bool enableSplitStack {get; set;}

        [Label("[i:RedDye] Enable Item Coloring?")]
        [Tooltip("If true, players can color items by RightClicking with a dye of their choice.\n(Disabled by default because it is still being worked on.)")]
        [DefaultValue(false)]
        public bool enableItemColoring {get; set;}

        [Label("[i:HermesBoots] Enable Walking?")]
        [Tooltip("If true, players can control their movement speed through the dedicated keybind.\nIncrease/Decrease speed with the Mouse Scroll-Wheel while Walking is active.")]
        [DefaultValue(true)]
        public bool enableWalking {get; set;}

        [Label("[i:SailfishBoots] Enable Sprinting?")]
        [DefaultValue(false)]
        public bool enableSprinting {get; set;}

        [Label("[i:SailfishBoots] Sprint Speed")]
        [Slider]
        [DefaultValue(1.5f)]
        [Range(1.10f, 3f)]
        [Increment(0.10f)]
        public float sprintSpeed {get; set;}

        [Label("[i:Cog][i:HermesBoots] Fix the Walk Speed Bug?")]
        [Tooltip("Accessories like the Hermes Boots take effect when walking at a certain speed.\nThis option fixes that.\nDisabled by default for now because it messes with the Fast Walking feature.")]
        [DefaultValue(false)]
        public bool fixWalkSpeed {get; set;}
    }
}
