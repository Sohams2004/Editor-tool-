using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class Waypoints : MonoBehaviour
{
    [SerializeField] public Transform[] wayPoints;
    LinkedList<Transform> way_Points; 
    private void Start()
    {
        way_Points = new LinkedList<Transform>(wayPoints);
        
        way_Points.AddFirst(gameObject.transform);
        Debug.Log(way_Points.Count);
    }

    private void OnDrawGizmos()
    {
        Pathway();
        Gizmos.color = Color.green;

        if(way_Points !=  null )
        {
            foreach (Transform points in way_Points)
            {
                if (points != null)
                {
                    Gizmos.DrawSphere(points.position, 0.1f);
                }
            }
        }
    }

    void Pathway()
    {
        Gizmos.color = Color.yellow;

        if(wayPoints !=  null)
        {
            for (int i = 0; i < wayPoints.Length - 1; i++)
            {
                if (wayPoints[i] != null)
                {
                    Vector3 currentPoint = wayPoints[i].position;
                    Vector3 nextPoint = wayPoints[i + 1].position;
                    Gizmos.DrawLine(currentPoint, nextPoint);
                }            
            }
        }
    }
}
