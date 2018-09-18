using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent (typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {

    //Camera
    public float movementSpeed = 5.0f;
    public float mouseSensitivity = 5.0f;
    public float verticalRotation = 0;
    public float UpDownRange = 60.0f;
    public float verticalVelocity = 0;
    public float horizontalVelocity = 0;
    //jump
    public float jumpSpeed = 20.0f;

    public float gravity = 9.8f;
    float height;
    
    //public float Fall_Multiplier = 2.5f;
    //public float lowjump_multiplier = 2f;

    //dash   
    public bool dashing = false;
    public float DashTime = 0.5f;
    public float DashRate = 3f;
    public float NextDash;

    //sound
    public AudioSource jump_sound;
    public AudioSource dash_sound;

    CharacterController cc;
    
   // public Transform canvas; 
  
	// Use this for initialization
	void Start ()
    {
        cc = GetComponent<CharacterController>();
        //Screen.lockCursor = true;
	}
	// Update is called once per frame
    void Update()
    {
        //camera
        float horizontalRotation = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, horizontalRotation, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -UpDownRange, UpDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);

        //clock += Time.deltaTime;

        //movemnent
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;
        verticalVelocity += Physics.gravity.y * Time.deltaTime;
        

        if (cc.isGrounded && Input.GetButton("Jump"))
        {
            verticalVelocity = jumpSpeed;
            jump_sound.Play();
        }
        
        if (cc.isGrounded == false)
        {
           verticalVelocity -= gravity * Time.deltaTime; //verticalVelocit= verticalVelocity - gravity*time.delta
        }
        //dash

        if (Input.GetButtonDown("Dash") && Time.time > NextDash)
        {
            dash_sound.Play();
            NextDash = Time.time + DashRate;    
            StartCoroutine(Dash()); 
        }

       
    
       /* if(canvas.gameObject.activeInHierarchy == true)
        {
            mouseSensitivity = 0;
        }
        else if(canvas.gameObject.activeInHierarchy == false)
        {
            mouseSensitivity = 5;
        }*/
  
        
        

        Vector3 speed = new Vector3(sideSpeed, verticalVelocity, forwardSpeed);


        speed = transform.rotation * speed;


        cc.Move(speed * Time.deltaTime);
    }

    IEnumerator Fall()
    {
        if(GetComponent<CharacterController>().isGrounded == false)
        {
            yield return new WaitForSeconds(1);

            verticalVelocity -= gravity * Time.deltaTime;
        }
    }

    IEnumerator Dash()
    {
        movementSpeed = movementSpeed * 3;
        dashing = true;

            yield return new WaitForSeconds(DashTime);

        movementSpeed = movementSpeed / 3;
        dashing = false;
    }

    
    

}
