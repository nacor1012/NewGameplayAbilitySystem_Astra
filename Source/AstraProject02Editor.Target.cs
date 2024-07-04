// Copyright SkyHigh Gaming.

using UnrealBuildTool;
using System.Collections.Generic;

public class AstraProject02EditorTarget : TargetRules
{
	public AstraProject02EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "AstraProject02" } );
	}
}
