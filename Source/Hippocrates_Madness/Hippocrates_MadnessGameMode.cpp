// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "Hippocrates_MadnessGameMode.h"
#include "Hippocrates_MadnessHUD.h"
#include "Hippocrates_MadnessCharacter.h"
#include "UObject/ConstructorHelpers.h"

AHippocrates_MadnessGameMode::AHippocrates_MadnessGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = AHippocrates_MadnessHUD::StaticClass();
}
