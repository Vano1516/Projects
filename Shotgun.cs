using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject gun_on_floor;
    public GameObject gun_equip;

    public void equip_gun()
    {
        gun_on_floor.SetActive(false);
        gun_equip.SetActive(true);


    }
}
