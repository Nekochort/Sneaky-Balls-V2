using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField][Range(1f, 5f)] private float distance = 3f;
    [SerializeField][Range(0.5f, 5f)] private float height = 0.7f;
    [SerializeField][Range(0f, 1f)] private float moveSpeed = 0.125f;
    [SerializeField][Range(0f, 350f)] private float sensitivity = 500f;
    [SerializeField] FloatingJoystick camJoystick;
    private float angle = 0;

    private void Start()
    {
        target.transform.rotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        angle -= camJoystick.Direction.y * sensitivity * Time.fixedDeltaTime;
        angle = Mathf.Clamp(angle, -15, 15);
        target.transform.eulerAngles = new Vector3(
        angle, target.transform.eulerAngles.y + camJoystick.Direction.x * sensitivity * Time.fixedDeltaTime);

        Vector3 positionToGo = (target.position - target.forward * distance) + Vector3.up * height;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, positionToGo, moveSpeed);
        transform.position = smoothPosition;

        transform.LookAt(target.position + Vector3.up * (height * 0.8f));
    }
}
