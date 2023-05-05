using UnrealBuildTool;

public class FNaF_ReimaginedTarget : TargetRules
{
	public FNaF_ReimaginedTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FNaF_Reimagined");
	}
}
