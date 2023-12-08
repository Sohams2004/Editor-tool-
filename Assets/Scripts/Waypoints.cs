using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] Transform[] wayPoints;

    private void OnDrawGizmos()
    {
        Pathway();
        Gizmos.color = Color.green;

        foreach (Transform t in wayPoints)
        {
            if(t != null)
            {
                Gizmos.DrawSphere(t.position, 0.1f);
            }         
        }
    }

    void Pathway()
    {
        Gizmos.color = Color.yellow;

        for (int i = 0; i < wayPoints.Length - 1; i++)
        {
            Vector3 currentPoint = wayPoints[i].position;
            Vector3 nextPoint = wayPoints[i+1].position;
            Gizmos.DrawLine(currentPoint, nextPoint);
        }
    }
}
