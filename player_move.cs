using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player_move : MonoBehaviour
{
    public float speed_move;
    public float speed_run ;
    public float speed_current;
    float x_move;
    float z_move;

    public float jump;
    public float gravity;

    [SerializeField] Slider staminaSlider;
    [SerializeField] float staminaValue;
    [SerializeField] float minValueStamina;
    [SerializeField] float maxValueStamina;

    private Text textStamina;
    
    //public GameObject gun;
    CharacterController player;
    Vector3 move_direction;
    void Start()
    {
        player = GetComponent<CharacterController>();

        textStamina = staminaSlider.transform.GetChild(3).GetComponent<Text>();        
    }
    void LateUpdate()
    {
        Move();
        //Stamina();
    }
    void Move()
    {
        x_move = Input.GetAxis("Horizontal");
        z_move = Input.GetAxis("Vertical");
        //move_direction = new Vector3(x_move,0f,z_move);
        //move_direction = transform.TransformDirection(move_direction);

      //  gun.Move(move_direction);
    if (player.isGrounded)
      {        
          move_direction = new Vector3(x_move,0f,z_move);
        move_direction = transform.TransformDirection(move_direction);
        if (Input.GetKey(KeyCode.Space))
      {
        move_direction.y+=jump;

      }

      }
    move_direction.y -=gravity;
    player.Move(move_direction*Time.deltaTime*speed_move);

   //стамина
  //  if (Input.GetKey(KeyCode.LeftShift) && staminaValue>0)
   // {
     // speed_current = speed_run; 
 //  }

   // else
   // {
   //   speed_current = speed_move;
   // }
    }

    private void Stamina()
    {
      if (maxValueStamina >100f)
      maxValueStamina =100f;

      staminaValue = staminaSlider.value;
      textStamina.text = staminaValue.ToString();

    }
}
