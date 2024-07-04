// Copyright SkyHigh Gaming.

using UnrealBuildTool;
using System.Collections.Generic;

public class AstraProject02Target : TargetRules
{
	public AstraProject02Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "AstraProject02" } );
	}
}
