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
        //EditorGUILayout.LabelField(enemyData.enemyName.ToUpper(), EditorStyles.boldLabel); 

        base.OnInspectorGUI();

        if(enemyData.enemyName == string.Empty)
        {
            EditorGUILayout.HelpBox("Please specify the name of the enemy!", MessageType.Warning);
        }

        if(enemyData.enemyThreatLevel == EnemyThreatLevel.None)
        {
            EditorGUILayout.HelpBox("Please select enemy threat level", MessageType.Warning);
        }

        if(enemyData.health >= 100)
        {
            enemyData.health = 100;
            EditorGUILayout.HelpBox("Maximum health can be 100 only", MessageType.Info);
        }

        if(enemyData.health <= 1)
        {
            enemyData.health = 1;
            EditorGUILayout.HelpBox("Helth cannot be less than 1", MessageType.Warning);
        }

        if(enemyData.damage <= 0 )
        {
            enemyData.damage = 0;
            EditorGUILayout.HelpBox("Damage cannot be less than 0", MessageType.Warning);
        }

        if(enemyData.movementSpeed <= 0)
        {
            enemyData.movementSpeed = 0;
            EditorGUILayout.HelpBox("Movement Speed cannot be less than 0", MessageType.Warning);
        }
    }
}
