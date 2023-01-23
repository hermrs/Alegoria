using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.Audio;
public class PlayerMovement : MonoBehaviour
{
    public Collector escp;
    public CharacterController controller;
    public float speed = 12f;
    public float runspeed;
    public float normalspeed = 12f;
    Vector3 velocity;
    float gravity = -13.8f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight;
    public bool alive;
    public GameObject dedscreen;
    public bool Escapable = false;
    public GameObject kacabilirsin;
    public GameObject footsteps;
    public GameObject flsound;
    public GameObject platformeyes;
    void Start()
    {
        escp=GetComponent<Collector>(); 
        alive = true;
        GetComponent<MouseLook>();
        

    }


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        run();
        if (alive == false)
        {
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(ureded());
        }
        if (escp.shard == 3)
        {
            kacabilirsin.SetActive(true);
            Escapable = true;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            footsteps.SetActive(true);
        }
        else
        {
            footsteps.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            flsound.SetActive(true);
            StartCoroutine(lightcloser());
        }
        if(Escapable == true)
        {
            platformeyes.SetActive(true);
        }

}

        public void run()
        {
            runspeed = 16f;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = runspeed;
            }
            else
            {
                speed = normalspeed;
            }

        }
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "creature")
            {

                alive = false;
            }
     
            if(other.gameObject.tag == "escapezone")
        {
            if(Escapable == true)
            {
                Debug.Log("Kactin");
            }
        }




        }
        IEnumerator ureded()
        {
            yield return new WaitForSeconds(0.6f);
            dedscreen.SetActive(true);
        }
       IEnumerator lightcloser()
    {
        yield return new WaitForSeconds(0.3f);
        flsound.SetActive(false);
    }
    
    
}
