using UnityEngine;

public class DeadPlatform : MonoBehaviour
{
    private GameObject respawnPlayer;
    public GameObject[] spawns;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            respawnPlayer = collision.gameObject;
            Vector3 randomPosition = spawns[0].transform.localPosition;
            respawnPlayer.transform.position = randomPosition;
        }
    }
}
