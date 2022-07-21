using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NicknameLook : MonoBehaviour {
    private void Start()
    {
        GetComponent<Canvas>().transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    void Update()
    {
        Vector3 relativePos = GameObject.FindGameObjectWithTag("MainCamera").transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, new Vector3(0,1,0));
        transform.rotation = rotation;
    }
}
