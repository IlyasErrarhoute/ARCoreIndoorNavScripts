using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Camera topDownCamera;
    [SerializeField]
    private GameObject navZielObjekt;
    private NavMeshPath pfad;
    private LineRenderer line;

    private bool lineToggle = false;

    private void Start()
    {
        pfad = new NavMeshPath();
        line.transform.GetComponent<LineRenderer>();

    }
    private void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            lineToggle = !lineToggle;
        }
        if (true)
        {
            NavMesh.CalculatePath(transform.position, navZielObjekt.transform.position, NavMesh.AllAreas, pfad);
            line.positionCount = pfad.corners.Length;
            line.SetPositions(pfad.corners);
            line.enabled = true;


        }
    }
}
