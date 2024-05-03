using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;
using QualityTweaks.Common.Systems;
using QualityTweaks.Common.Configs;

namespace QualityTweaks.Common.Players{
	public class MovementControl : ModPlayer{
		public bool walking = false;
		public bool sprinting = false;
		public float walkSpeed = 0.50f;
		public override void ProcessTriggers(TriggersSet triggersSet){
			var player = Main.LocalPlayer;
			if(QualityTweaksKeybinds.Walk.JustPressed){if(!QualityTweaksClient.Instance.WalkingToggle && QualityTweaksServer.Instance.Walking){walking = !walking;}}
			if(QualityTweaksKeybinds.Walk.Current){if(QualityTweaksClient.Instance.WalkingToggle && QualityTweaksServer.Instance.Walking){walking=true;}}
			if(QualityTweaksKeybinds.Walk.JustReleased){if(QualityTweaksClient.Instance.WalkingToggle){walking=false;}}
			if(QualityTweaksKeybinds.Sprint.Current){if(QualityTweaksServer.Instance.Sprinting){sprinting=true;}}
			if(QualityTweaksKeybinds.Sprint.JustReleased){sprinting=false;}
		}
		public override void PostUpdateMiscEffects(){
			var player = Main.LocalPlayer;
			if(walking){
				PlayerInput.LockVanillaMouseScroll("Walking");
				if(QualityTweaksServer.Instance.FixWalkSpeed){player.velocity.X *= 0.95f;}
				if(PlayerInput.ScrollWheelDelta > 0 && walkSpeed < 1f){walkSpeed += 0.05f;}
				if(PlayerInput.ScrollWheelDelta < 0 && walkSpeed > 0f){walkSpeed -= 0.05f;}
			}
		}
		public override void PostUpdateRunSpeeds(){
			var player = Main.LocalPlayer;
			if(QualityTweaksServer.Instance.SlowMovement){player.accRunSpeed *= 0.65f; player.maxRunSpeed *= 0.65f;}
			if(walking){player.accRunSpeed *= walkSpeed; player.maxRunSpeed *= walkSpeed;}
			if(sprinting){
				if(walking && walkSpeed <= 0.5f){player.accRunSpeed *= 2f; player.maxRunSpeed *= 2f;}
				if(!walking && QualityTweaksServer.Instance.Sprinting){player.accRunSpeed *= 1.5f; player.maxRunSpeed *= 1.5f;}
			}
		}
		public override void ModifyHurt(ref Player.HurtModifiers modifiers){
			if(walking){walking=false;}
		}
	}
}
