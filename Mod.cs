using Terraria.ModLoader;
using Terraria.Audio;

namespace QualityTweaks
{
	public class QualityTweaks : Mod
	{
	public static ModKeybind ToggleBuilding;
        public static ModKeybind ToggleMusic;
        public static ModKeybind ToggleSound;
        public static ModKeybind ToggleAmbient;
        public static ModKeybind Walk;
        public static ModKeybind Sprint;
		
        public override void Load()
        {
            base.Load();
            QualityTweaksConfigBundles.Instance = ModContent.GetInstance<QualityTweaksConfigBundles>();
            ToggleBuilding = KeybindLoader.RegisterKeybind(this, "Toggle Building", "OemTilde");
            ToggleMusic = KeybindLoader.RegisterKeybind(this, "Toggle Music", "P");
            ToggleSound = KeybindLoader.RegisterKeybind(this, "Toggle Sound", "P");
            ToggleAmbient = KeybindLoader.RegisterKeybind(this, "Toggle Ambient", "P");
            Walk = KeybindLoader.RegisterKeybind(this, "Walk", "LeftControl");
            Sprint = KeybindLoader.RegisterKeybind(this, "Sprint/Fast Walk", "LeftShift");
        }
        
        public override void Unload()
        {
            ToggleBuilding = null;
            ToggleMusic = null;
            ToggleSound = null;
            ToggleAmbient = null;
            Walk = null;
            Sprint = null;
        }
    }
    	//	I'm not sure if 'partial' is required, but I've seen it in other places, so I'll keep it just in case.
	public static partial class Sounds
	{
		public static class Item
		{
			public static readonly SoundStyle BundleInsert = new($"{nameof(QualityTweaks)}/Sounds/BundleInsert", 3)
			{
				Volume = 0.5f,
				PitchVariance = 0.25f,
				MaxInstances = 12
			};
			public static readonly SoundStyle BundleExtract = new($"{nameof(QualityTweaks)}/Sounds/BundleExtract", 3)
			{
				Volume = 0.5f,
				PitchVariance = 0.25f,
				MaxInstances = 12
			};
			public static readonly SoundStyle BundleDump = new($"{nameof(QualityTweaks)}/Sounds/BundleDump", 3)
			{
				Volume = 0.5f,
				PitchVariance = 0.25f,
				MaxInstances = 12
			};
		}
	}
}
