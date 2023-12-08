using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EnemyData))]
public class EnemyDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EnemyData enemyData = target as EnemyData;
        EditorGUILayout.LabelField(enemyData.name.ToUpper(), EditorStyles.boldLabel); 

        base.OnInspectorGUI();
    }
}
