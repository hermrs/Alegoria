using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.TextCore.Text;
using UnityEngine;

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
    
    void Start()
    {
        escp=GetComponent<Collector>(); 
        alive = true;
        GetComponent<MouseLook>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        run();
        if(alive == false)
        {
            Cursor.lockState = CursorLockMode.None;
            StartCoroutine(ureded());
        }
        if (escp.shard == 3)
        {
            Escapable = true;  
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
    }
    IEnumerator ureded()
    {
        yield return new WaitForSeconds(0.6f);
        dedscreen.SetActive(true);
    }
    
}
