using System.Collections.Generic;
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ActionControl
{
    [Label("Client Config")]
    public class ActionControlConfigClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
		
        public static ActionControlConfigClient Instance;
		
	[Header("General")]
		
        [Label("[i:HermesBoots] Hold, or Toggle Walking?")]
        [Tooltip("Off for Hold, On for Toggle.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool toggleWalking {get; set;}
    }
}