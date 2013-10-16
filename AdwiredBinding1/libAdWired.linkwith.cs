using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libAdWired.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = false,
                     Frameworks="AudioToolbox QuartzCore CFNetwork SystemConfiguration MediaPlayer MessageUI CoreGraphics UIKit Foundation",
                     LinkerFlags="-lstdc++ -lstdc++.6")]
