// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RaftWars : ModuleRules
{
	public RaftWars(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "OnlineSubsystem", "OnlineSubsystemSteam" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
