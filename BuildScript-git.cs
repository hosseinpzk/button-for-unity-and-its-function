
////// This file should be in Assets/Editor 

using UnityEditor;
using UnityEngine;


public static class BuildScript
{
    public static void BuildAndroid()
    {
        
		var scenes = EditorBuildSettings.scenes
            .Where(s => s.enabled)
            .Select(s => s.path)
            .ToArray();
		
		var outPath = "Builds/AAB";

        ///////////////////////
        //////////////////////
        
		//// How to build funtion

        //////////////////////
        //////////////////////

    }

    public static void BuildiOS()
    {
        var scenes = EditorBuildSettings.scenes
            .Where(s => s.enabled)
            .Select(s => s.path)
            .ToArray();

        var outPath = "Builds/iOS";
		
		//////////////////////
        //////////////////////
        
		//// How to build funtion

        //////////////////////
        //////////////////////



    }
}
