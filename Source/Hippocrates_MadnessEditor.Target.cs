// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Hippocrates_MadnessEditorTarget : TargetRules
{
	public Hippocrates_MadnessEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Hippocrates_Madness");
	}
}
