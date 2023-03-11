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
		public float walkSpeed = 0.35f;
		public bool sprinting = false;
		
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

			//	Movement
			if (ActionControl.Walk.JustPressed)
			{
				//	If Toggle..
				if (ActionControlConfigClient.Instance.toggleWalking)	{	walking = !walking;	}
			}
			if (ActionControl.Walk.Current)
			{
				//	If Hold..
				if (!ActionControlConfigClient.Instance.toggleWalking)	{	walking = true;	}
			}
			if (ActionControl.Walk.JustReleased)
			{
				//	If Hold..
				if (!ActionControlConfigClient.Instance.toggleWalking)	{	walking = false;	}
			}
			if (ActionControl.Sprint.Current)	{	sprinting = true;	}
			if (ActionControl.Sprint.JustReleased)	{	sprinting = false;	}

			//	Volume
			if (ActionControl.ToggleMusic.JustPressed)
			{
				if (Main.musicVolume > 0f)	{	Main.musicVolume = 0f;	}
				else	{	Main.musicVolume = 1f;	}
			}
			if (ActionControl.ToggleSound.JustPressed)
			{
				if (Main.soundVolume > 0f)	{	Main.soundVolume = 0f;	}
				else	{	Main.soundVolume = 1f;	}
			}
			if (ActionControl.ToggleAmbient.JustPressed)
			{
				if (Main.ambientVolume > 0f)	{	Main.ambientVolume = 0f;	}
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
					player.accRunSpeed *= 2f;
					player.maxRunSpeed *= 2f;
				}
				if (!walking && ActionControlConfigServer.Instance.enableSprinting)
				{
					player.accRunSpeed *= ActionControlConfigServer.Instance.sprintSpeed;
					player.maxRunSpeed *= ActionControlConfigServer.Instance.sprintSpeed;
				}
			}
		}
	}
}