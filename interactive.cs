using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive : MonoBehaviour
{
    public GameObject Gun;

    [SerializeField] private Camera _fpsCamera;
    private Ray _ray;
    private RaycastHit _hit;
    Shotgun shotgun;
    [SerializeField] private float _maxDistanceRay=2f;
    // Start is called before the first frame update
    private void Update()
    {
        Ray();
        DrawRay();
        Interact();
    }

    // Update is called once per frame
    private void Ray()
    {
        _ray = _fpsCamera.ScreenPointToRay(new Vector2(Screen.width/2,Screen.height/2));
    }

    private void DrawRay()
    {
        if (Physics.Raycast(_ray,out _hit,_maxDistanceRay))
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay,Color.blue);
        }
        if (_hit.transform == null)
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay,Color.red);
        }
    }
    private void Interact()
    {
        if (_hit.transform!= null &&_hit.transform.GetComponent<Shotgun>())
        {
            Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.green);
            if (Input.GetKeyDown(KeyCode.E))
            {
                //Gun.SetActive(false);
                _hit.transform.GetComponent<Shotgun>().equip_gun();
            }
        }
    }


}
