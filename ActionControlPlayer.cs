//	Keeping this here for when Key Detection will be required.
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
//	This will be necessary later on.
using static Terraria.Mount;

namespace ActionControl
{
    public class ActionControlPlayer : ModPlayer
    {
		public bool cannotBuild = false;
		public bool walking = false;
		public float walkSpeed = 0.45f;
		
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			var player = Main.LocalPlayer;
			//	Keeping this here for reference.
			//if (Main.keyState.IsKeyDown(Keys.LeftShift))
			
			//	Building
			if (ActionControl.ToggleBuilding.JustPressed)
			{
				//cannotBuild = !cannotBuild;
				if (!cannotBuild)
				{
					cannotBuild = true;
					SoundEngine.PlaySound(SoundID.Unlock with {Pitch = -0.50f, Volume = 1f}, player.position);
				}
				else
				{
					cannotBuild = false;
					SoundEngine.PlaySound(SoundID.Unlock with {Pitch = +0.50f, Volume = 1f}, player.position);
				}
			}
			//	Walking
			if (ActionControl.Walk.Current)
			{
				walking = true;
			}
			if (ActionControl.Walk.JustReleased)
			{
				walking = false;
			}
			//	Volume
			if (ActionControl.ToggleMusic.JustPressed)
			{
				if (Main.musicVolume > 0f)
				{
					Main.musicVolume = 0f;
				}
				else
				{
					Main.musicVolume = 1f;
				}
			}
		}
		public override void PostUpdateMiscEffects()
		{
			var player = Main.LocalPlayer;

			if (cannotBuild)
			{
				player.noBuilding = true;
			}

			//	Walking
			if (walking)
			{
				PlayerInput.LockVanillaMouseScroll("walking");
				if (PlayerInput.ScrollWheelDelta > 0 && walkSpeed < 1f)
				{
					walkSpeed += 0.10f;
					//SoundEngine.PlaySound(SoundID.Run with {Pitch = +0.5f, Volume = 1f}, player.position);
				}
				if (PlayerInput.ScrollWheelDelta < 0 && walkSpeed > 0f)
				{
					walkSpeed -= 0.10f;
					//SoundEngine.PlaySound(SoundID.Run with {Pitch = -0.5f, Volume = 1f}, player.position);
				}
			}
		}
		public override void PostUpdateRunSpeeds()
		{
			var player = Main.LocalPlayer;

			if (walking)
			{
				player.accRunSpeed *= walkSpeed;
				player.maxRunSpeed *= walkSpeed;
			}
		}
	}
}