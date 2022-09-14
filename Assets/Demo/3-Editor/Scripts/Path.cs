using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Vector3[] points;

    private void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "mono-tool-curve");
    }
}
