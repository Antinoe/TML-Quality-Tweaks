using Terraria.ModLoader;


namespace ActionControl
{
	public class ActionControl : Mod
	{
		public static ModKeybind ToggleBuilding;
        public static ModKeybind Walk;
		
        public override void Load()
        {
            ToggleBuilding = KeybindLoader.RegisterKeybind(this, "Toggle Building", "OemTilde");
            Walk = KeybindLoader.RegisterKeybind(this, "Walk", "LeftShift");
        }
        
        public override void Unload()
        {
            ToggleBuilding = null;
            Walk = null;
        }
    }
}