using Terraria.ModLoader;

namespace QualityTweaks.Common.Systems{
	public class QualityTweaksKeybinds : ModSystem
	{
		public static ModKeybind Walk{get;private set;}
		public static ModKeybind Sprint{get;private set;}
		public static ModKeybind ToggleBuilding{get;private set;}
		public override void Load() {
			Walk = KeybindLoader.RegisterKeybind(Mod,"Walk","X");
			Sprint = KeybindLoader.RegisterKeybind(Mod,"Sprint","LeftShift");
			ToggleBuilding = KeybindLoader.RegisterKeybind(Mod,"ToggleBuilding","`");
		}
		public override void Unload(){
			Walk = null;
			Sprint = null;
			ToggleBuilding = null;
		}
	}
}
