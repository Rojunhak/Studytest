using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quternion_LookRotation : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.Inverse(Quaternion.LookRotation(relativePos, Vector3.up));
        transform.rotation = rotation;
        //타겟을 계속 바라보게 하는 함수?
    }
}
