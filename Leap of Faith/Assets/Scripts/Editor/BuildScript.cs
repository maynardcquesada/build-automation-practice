using UnityEditor;

public class BuildScript
{
    private static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/Playground.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/gamex86_64", BuildTarget.StandaloneWindows64,
            BuildOptions.None);
    }
}