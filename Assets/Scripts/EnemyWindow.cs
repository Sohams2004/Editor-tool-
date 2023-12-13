using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWindow : EditorWindow
{
    Vector2 scrollBarPos = Vector2.zero;

    [SerializeField] Waypoints waypoints;

    SerializedObject serializedObject;
    SerializedProperty wayPointArray;

    [MenuItem("Window/Visual Path tool")]
    public static void Window()
    {
        GetWindow<EnemyWindow>("Way Point tool");
        EnemyWindow window = (EnemyWindow)GetWindow(typeof(EnemyWindow));
    }

    private void OnEnable()
    {
        waypoints = FindObjectOfType<Waypoints>();

        serializedObject = new SerializedObject(waypoints);
        wayPointArray = serializedObject.FindProperty("wayPoints");
    }

    private void OnGUI()
    {
        //Title
        GUILayout.Label("Way Point Visualizer");

        GUILayout.Space(10);

        //Way point array
        //GUILayout.Label("Waypoints");

        EditorGUILayout.PropertyField(wayPointArray, true);
        serializedObject.ApplyModifiedProperties();

        GUILayout.Space(10);

        //Clear array button
        if (GUILayout.Button("Clear"))
        {
            Clear();
        }
    }

    void Clear()
    {
        wayPointArray.ClearArray();
    }
}
