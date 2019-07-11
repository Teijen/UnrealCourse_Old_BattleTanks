// Copyright Logan Cannan 2019

using UnrealBuildTool;
using System.Collections.Generic;

public class Old_BattleTanksEditorTarget : TargetRules
{
	public Old_BattleTanksEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Old_BattleTanks" } );
	}
}
