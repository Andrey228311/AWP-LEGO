using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpineMove : MonoBehaviour
{
    private Transform AWP;
    private Transform RightHandIndex2;
    private void Update()
    {
        AWP.transform.parent = RightHandIndex2.transform;
        AWP.transform.localPosition = Vector3.zero;

    }
}