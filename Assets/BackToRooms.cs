using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToRooms : MonoBehaviour
{
    public void DisconnectPlayer()
    {
        StartCoroutine(DisconnectAndLoad());
    }

    IEnumerator DisconnectAndLoad()
    {
        PhotonNetwork.LeaveRoom();
        while (PhotonNetwork.InRoom)
            yield return null;
        SceneManager.LoadScene("MainMenu");
    }
}
