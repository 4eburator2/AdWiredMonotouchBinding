using System;

namespace AdwiredBinding
{

	public enum AWViewAnimation {
		Undefined = 0,
		None,
		Simple,
		Thin
	}

	public enum AWBannerType {
		Undefined = 0,
		Standart,
		Fullscreen,
		Slim,
		Custom
	}

	public enum AWBannerOrientation {
		None = 0,
		Portrait = 1 << 0,
		PortraitUpsideDown = 1 << 1,
		LandscapeLeft = 1 << 2,
		LandscapeRight = 1 << 3,
		All = 8
	}
}