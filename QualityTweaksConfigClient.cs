using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace QualityTweaks
{
    [Label("Client Config")]
    public class QualityTweaksConfigClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public static QualityTweaksConfigClient Instance;
		
	[Header("General")]
		
        [Label("[i:HermesBoots] Hold, or Toggle Walking?")]
        [Tooltip("Off for Hold, On for Toggle.\n[Default: Off]")]
        [DefaultValue(false)]
        public bool toggleWalking {get; set;}

        [Label("[i:HermesBoots] Fast Walk Speed")]
        [Tooltip("Multiplied Walk Speed when holding the Sprint keybind while Walking.\n[Default: 2]")]
        [Slider]
        [DefaultValue(2f)]
        [Range(1.05f, 2f)]
        [Increment(0.05f)]
        public float fastWalkSpeed {get; set;}

        [Label("[i:Megaphone] Volume Toggle Amount")]
        [Tooltip("The volume of audio when toggled off.\n[Default: 0.01]")]
        [Slider]
        [DefaultValue(0.01f)]
        [Range(0f, 1f)]
        [Increment(0.01f)]
        public float volumeToggleAmount {get; set;}
    }
}
