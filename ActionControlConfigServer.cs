using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ActionControl
{
    [Label("Server Config")]
    public class ActionControlConfigServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        public static ActionControlConfigServer Instance;
		
	[Header("General")]
		
        [Label("[i:SailfishBoots] Enable Sprinting?")]
        [Tooltip("[Default: Off]")]
        [DefaultValue(false)]
        public bool enableSprinting {get; set;}

        [Label("[i:SailfishBoots] Sprint Speed")]
        [Tooltip("[Default: 1.5]")]
        [Slider]
        [DefaultValue(1.5f)]
        [Range(1.10f, 3f)]
        [Increment(0.10f)]
        public float sprintSpeed {get; set;}
    }
}
