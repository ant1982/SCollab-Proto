using UnrealBuildTool;

public class SP_PrototypeTarget : TargetRules
{
	public SP_PrototypeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SP_Prototype");
	}
}
