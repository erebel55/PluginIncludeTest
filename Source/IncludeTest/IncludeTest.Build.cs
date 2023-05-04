// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class IncludeTest : ModuleRules
{
	public IncludeTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "PluginA", "PluginB" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
