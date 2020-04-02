// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Hippocrates_MadnessTarget : TargetRules
{
	public Hippocrates_MadnessTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Hippocrates_Madness");
	}
}
