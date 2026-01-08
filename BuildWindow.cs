////// This file should be in Assets/Editor 

using UnityEditor;
using UnityEngine;

public class BuildWindow : EditorWindow
{
    [MenuItem("Tools/Build Window")]
    public static void Open()
    {
        GetWindow<BuildWindow>("Build");
    }

    private void OnGUI()
    {
        GUILayout.Label("Build Actions", EditorStyles.boldLabel);

        if (GUILayout.Button("Build Android"))
        {
            BuildScript.BuildAndroid();
        }

        if (GUILayout.Button("Build iOS"))
        {
            BuildScript.BuildiOS();
        }
    }
}

