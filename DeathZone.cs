using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class DeathZone : MonoBehaviour
{
    public GameObject Player;
    public GameObject TeleportTo;
    //public GameObject StartTeleporter;
 
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            Player.transform.position = TeleportTo.transform.position;
        }
 

    }
}