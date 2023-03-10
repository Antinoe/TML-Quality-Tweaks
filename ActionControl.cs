using Terraria.ModLoader;


namespace ActionControl
{
	public class ActionControl : Mod
	{
		public static ModKeybind ToggleBuilding;
        public static ModKeybind ToggleMusic;
        public static ModKeybind ToggleAmbient;
        public static ModKeybind Walk;
		
        public override void Load()
        {
            ToggleBuilding = KeybindLoader.RegisterKeybind(this, "Toggle Building", "OemTilde");
            ToggleMusic = KeybindLoader.RegisterKeybind(this, "Toggle Music", "P");
            ToggleAmbient = KeybindLoader.RegisterKeybind(this, "Toggle Ambient", "P");
            Walk = KeybindLoader.RegisterKeybind(this, "Walk", "LeftShift");
        }
        
        public override void Unload()
        {
            ToggleBuilding = null;
            ToggleMusic = null;
            ToggleAmbient = null;
            Walk = null;
        }
    }
}