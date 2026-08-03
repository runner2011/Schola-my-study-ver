using UnrealBuildTool;
using System.Collections.Generic;

public class ScholaMimicHostTarget : TargetRules
{
    public ScholaMimicHostTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V6;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("ScholaMimicHost");
    }
}
