//	Keeping this here for when Key Detection will be required.
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
//	This will be necessary later on.
using static Terraria.Mount;

namespace QualityTweaks
{
    public class QualityTweaksPlayer : ModPlayer
    {
		public bool cannotBuild = false;
		public bool walking = false;
		public float walkSpeed = 0.35f;
		public bool sprinting = false;
		
		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			var player = Main.LocalPlayer;
			//	Keeping this here for reference.
			//if (Main.keyState.IsKeyDown(Keys.LeftShift))
			
			//	Building
			if (QualityTweaks.ToggleBuilding.JustPressed)
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

			//	Movement
			if (QualityTweaks.Walk.JustPressed)
			{
				//	If Toggle..
				if (QualityTweaksConfigClient.Instance.toggleWalking)	{	walking = !walking;	}
			}
			if (QualityTweaks.Walk.Current)
			{
				//	If Hold..
				if (!QualityTweaksConfigClient.Instance.toggleWalking)	{	walking = true;	}
			}
			if (QualityTweaks.Walk.JustReleased)
			{
				//	If Hold..
				if (!QualityTweaksConfigClient.Instance.toggleWalking)	{	walking = false;	}
			}
			if (QualityTweaks.Sprint.Current)	{	sprinting = true;	}
			if (QualityTweaks.Sprint.JustReleased)	{	sprinting = false;	}

			//	Volume
			var volume = QualityTweaksConfigClient.Instance.volumeToggleAmount;
			if (QualityTweaks.ToggleMusic.JustPressed)
			{
				if (Main.musicVolume > volume)	{	Main.musicVolume = volume;	}
				else	{	Main.musicVolume = 1f;	}
			}
			if (QualityTweaks.ToggleSound.JustPressed)
			{
				if (Main.soundVolume > volume)	{	Main.soundVolume = volume;	}
				else	{	Main.soundVolume = 1f;	}
			}
			if (QualityTweaks.ToggleAmbient.JustPressed)
			{
				if (Main.ambientVolume > volume)	{	Main.ambientVolume = volume;	}
				else	{	Main.ambientVolume = 1f;	}
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
				Player.velocity.X *= 0.95f;
				PlayerInput.LockVanillaMouseScroll("walking");
				if (PlayerInput.ScrollWheelDelta > 0 && walkSpeed < 1f)
				{
					walkSpeed += 0.05f;
					//SoundEngine.PlaySound(SoundID.Run with {Pitch = +0.5f, Volume = 1f}, player.position);
				}
				if (PlayerInput.ScrollWheelDelta < 0 && walkSpeed > 0f)
				{
					walkSpeed -= 0.05f;
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
			if (sprinting)
			{
				//	The "less than 50% or less" check is here so you can't go faster than your Run Speed while Walking.
				if (walking && walkSpeed <= 0.5f)
				{
					player.accRunSpeed *= QualityTweaksConfigClient.Instance.fastWalkSpeed;
					player.maxRunSpeed *= QualityTweaksConfigClient.Instance.fastWalkSpeed;
				}
				if (!walking && QualityTweaksConfigServer.Instance.enableSprinting)
				{
					player.accRunSpeed *= QualityTweaksConfigServer.Instance.sprintSpeed;
					player.maxRunSpeed *= QualityTweaksConfigServer.Instance.sprintSpeed;
				}
			}
		}
	}
}
