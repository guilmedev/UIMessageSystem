using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(Test))]
public class TestEditor : Editor
{
    Test script;

    string messageString= "";

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        script = (Test)target;

        BuildButtons();
 
    }

    private void BuildButtons()
    {
        GUILayout.Space(10);

        messageString = GUILayout.TextArea(messageString, 150);

        if (GUILayout.Button("Add message", GUILayout.Height(30)))
        {
            if (!string.IsNullOrEmpty(messageString))
            {
                script.AddMessage( messageString );
                messageString = "";
            }
        }

        GUILayout.Space(10);

        if (GUILayout.Button("Show all messasges", GUILayout.Height(30)))
        {
            script.ShowAllMessages();
        }

    }
}
