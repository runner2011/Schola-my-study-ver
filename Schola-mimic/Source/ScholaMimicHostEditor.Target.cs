using UnrealBuildTool;
using System.Collections.Generic;

public class ScholaMimicHostEditorTarget : TargetRules
{
    public ScholaMimicHostEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V6;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("ScholaMimicHost");
    }
}
