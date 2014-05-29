

using UnrealBuildTool;
using System.Collections.Generic;

public class GameRoomVREditorTarget : TargetRules
{
	public GameRoomVREditorTarget(TargetInfo Target)
	{
		Type = TargetType.Editor;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "GameRoomVR" } );
	}
}
