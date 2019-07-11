// Copyright Logan Cannan 2019

using UnrealBuildTool;
using System.Collections.Generic;

public class Old_BattleTanksTarget : TargetRules
{
	public Old_BattleTanksTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Old_BattleTanks" } );
	}
}
