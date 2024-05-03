using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using QualityTweaks.Common.Systems;

namespace QualityTweaks.Common.Players{
	public class BuildingControl : ModPlayer{
		public bool cannotBuild = false;
		public override void ProcessTriggers(TriggersSet triggersSet){
			var player = Main.LocalPlayer;
			if (QualityTweaksKeybinds.ToggleBuilding.JustPressed){
				if (!cannotBuild){
					cannotBuild = true;
					SoundEngine.PlaySound(SoundID.Unlock with {Pitch=0.5f,Volume=1f},player.position);
				}
				else{
					cannotBuild = false;
					SoundEngine.PlaySound(SoundID.Unlock with {Pitch=1.50f,Volume=1f},player.position);
				}
			}
		}
		public override void PostUpdateMiscEffects(){
			var player = Main.LocalPlayer;
			if(cannotBuild){player.noBuilding=true;}
		}
	}
}
