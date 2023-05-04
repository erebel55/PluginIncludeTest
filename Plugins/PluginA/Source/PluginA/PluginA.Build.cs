// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System;
using System.IO;

public class PluginA : ModuleRules
{
	public PluginA(ReadOnlyTargetRules Target) : base(Target)
	{
		bAddDefaultIncludePaths = false;
		
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
		);
		
		string PluginSrcDir = Path.Combine(PluginDirectory, "Source");
		PrivateIncludePaths.Add(Path.Combine(PluginSrcDir, "PluginA/Classes/Foo"));
	}
}
