using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Stats")]
    [SerializeField] [Tooltip("Enemy difficulty level")] public EnemyThreatLevel enemyThreatLevel;
    [SerializeField] [Tooltip("Enemy name")] public string enemyName;
    [SerializeField] [Range(0,10)] [Tooltip("Radius in which enemy will detect player")] public float detectionRange;

    [Header("Enemy Combat Stats")]
    [SerializeField] [Tooltip("Enemy health. 0-100")] public int health;
    [SerializeField] [Tooltip("Damage dealt by enemy")] public int damage;
    [SerializeField] [Tooltip("The speed in which the enemy will move")] public float movementSpeed;
}
