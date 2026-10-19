// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Entregas_program : ModuleRules
{
	public Entregas_program(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Entregas_program",
			"Entregas_program/Variant_Platforming",
			"Entregas_program/Variant_Platforming/Animation",
			"Entregas_program/Variant_Combat",
			"Entregas_program/Variant_Combat/AI",
			"Entregas_program/Variant_Combat/Animation",
			"Entregas_program/Variant_Combat/Gameplay",
			"Entregas_program/Variant_Combat/Interfaces",
			"Entregas_program/Variant_Combat/UI",
			"Entregas_program/Variant_SideScrolling",
			"Entregas_program/Variant_SideScrolling/AI",
			"Entregas_program/Variant_SideScrolling/Gameplay",
			"Entregas_program/Variant_SideScrolling/Interfaces",
			"Entregas_program/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
