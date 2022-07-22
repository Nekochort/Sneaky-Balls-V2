using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NicknameLook : MonoBehaviour {
    [SerializeField] private float sizeMultiply = 0.0005f;
    void FixedUpdate()
    {
        Transform mainCam = GameObject.FindGameObjectWithTag("MainCamera").transform;
        transform.rotation = mainCam.rotation;

        float distance = Vector3.Distance(transform.position, mainCam.position) * sizeMultiply;
        transform.localScale = new Vector3(distance, distance);
    }
}
