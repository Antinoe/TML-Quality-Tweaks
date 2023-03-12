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

        [Label("[i:Megaphone] Volume Toggle Amount")]
        [Tooltip("The volume of audio when toggled off.\n[Default: 0.01]")]
        [Slider]
        [DefaultValue(0.01f)]
        [Range(0f, 1f)]
        [Increment(0.01f)]
        public float volumeToggleAmount {get; set;}
    }
}