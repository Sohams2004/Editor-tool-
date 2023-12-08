using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Enemy Stats")]
    [SerializeField] [Tooltip("Enemy difficulty level")] EnemyThreatLevel enemyThreatLevel;
    [SerializeField] [Tooltip("Enemy name")] string name;
    [SerializeField] [Range(0,50)] [Tooltip("Radius in which enemy will detect player")] public float detectionRange;

    [Header("Enemy Combat Stats")]
    [SerializeField] [Tooltip("Enemy health")] int health;
    [SerializeField] [Tooltip("Damage dealt by enemy")] int damage;
    [SerializeField] [Tooltip("The speed in which the enemy will move")] float movementSpeed;
}
