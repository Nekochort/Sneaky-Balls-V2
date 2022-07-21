using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NicknameLook : MonoBehaviour {
    void FixedUpdate()
    {
        Vector3 relativePos = GameObject.FindGameObjectWithTag("MainCamera").transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(-relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
