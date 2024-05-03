using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.Audio;
using Terraria.ModLoader;

namespace QualityTweaks{
	public class QualityTweaks : Mod{}
	public static partial class Sounds{
		public static class Bundles{
			public static readonly SoundStyle BundleDump = new SoundStyle("QualityTweaks/Assets/Sounds/Bundles/BundleDump",3){Volume=1f,PitchVariance=1f,MaxInstances=10};
			public static readonly SoundStyle BundleExtract = new SoundStyle("QualityTweaks/Assets/Sounds/Bundles/BundleExtract",3){Volume=1f,PitchVariance=1f,MaxInstances=10};
			public static readonly SoundStyle BundleInsert = new SoundStyle("QualityTweaks/Assets/Sounds/Bundles/BundleInsert",3){Volume=1f,PitchVariance=1f,MaxInstances=10};
		}
	}
}
