 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mouse_move : MonoBehaviour
{
    float speed=1f;
    float xRot;
    float yRot;
    float xRotCurrent;
    float yRotCurrent;
    public Camera player;
    public float sensivity = 5f;
    public GameObject playerGameObject;
    public GameObject Gun;

    public float smoothTime = 0.1f;
    float currentVelocityX;
    float currentVelocityY;
    // Start is called before the first frame updat

    void Update()
    {
        MouseMove();
    }
    void MouseMove()
    {
        xRot += Input.GetAxis("Mouse X")*sensivity;
        yRot += Input.GetAxis("Mouse Y")*sensivity;

        yRot = Mathf.Clamp(yRot,-90,90);

        xRotCurrent = Mathf.SmoothDamp(xRotCurrent,xRot,ref currentVelocityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRotCurrent,yRot,ref currentVelocityY, smoothTime);
        player.transform.rotation = Quaternion.Euler(-yRotCurrent,xRotCurrent,0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f,xRotCurrent,0f);
        //Gun.transform.rotation = Quaternion.Euler(0f,xRotCurrent,0f);
       
    }
}
