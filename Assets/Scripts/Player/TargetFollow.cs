using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    [SerializeField] Transform followObject;
    void FixedUpdate()
    {
        transform.position = followObject.position;
    }
}
