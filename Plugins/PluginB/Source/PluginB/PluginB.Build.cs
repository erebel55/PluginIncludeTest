// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PluginB : ModuleRules
{
	public PluginB(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
	}
}
