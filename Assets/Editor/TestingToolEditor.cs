using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(TestingTool))]
public class TestingToolEditor : Editor
{
    public TestingTool testingTool;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Fire GameState Event"))
        {
            testingTool.RaiseGameStateChangeEvent();
        }
    }
}
