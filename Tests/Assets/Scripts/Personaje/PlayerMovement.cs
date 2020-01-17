using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    
    [Header("Controlador")]
    public CharacterController controller;
    public Animator anim;

    [Header("Variables")]
    public float speed = 4f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 3f;
    [SerializeField] public float agachado = 0.5f;
    float levantado = 1.8f;

    [Header("ManagerVariables")]
    public GameManager manager;
    
    [Header("Checkers")]
    
   public bool isGrounded;
   public bool Crouch = false;
    public bool isRuning = false;
    [SerializeField]
    private bool canMove;

    [Header("Contadores")]
    float MaxJump;
    public float JumpCount;


    [Header("Otros")]
    public Transform groundCheck;
    public LayerMask groundMask;


    Vector3 velocity;

    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            JumpCount = 0;
        }


        Movement();

        

        GroundCheck();

        Salto();

        Gravedad();

        Agacharse();

        Melee();

        deslizar();
        
    }


     void Movement()
    {
        float x = 0, z = 0;

        if (canMove)
        {
            //Movimiento del Personaje
             x = Input.GetAxis("Horizontal");
             z = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.LeftShift) && (Crouch == false))
            {
                isRuning = true;
                speed = 6f;
            }
            else
            {
                isRuning = false;
                speed = 4f;
            }
            move = transform.right * x + transform.forward * z;


            if (manager.Red == true)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    canMove = false;
                    speed = 20;

                    move = transform.forward;

                    Invoke("endDash", 0.5f);
                }
            }

         



        }

      controller.Move(move * speed * Time.deltaTime);
     }

    void GroundCheck()
    {
        //Saber si Esta en el suelo y reducir la velocidad de caida.
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }

     void Salto()
    {
        //Salto del Personaje
        if (manager.Green != true)
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

                JumpCount += 1;
            }
        }
      

        if(manager.Green == true)
        {
            if (Input.GetButtonDown("Jump") && (isGrounded || MaxJump >= JumpCount))
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

                JumpCount += 1;
            }
        }
        
    }

     void Melee()
    {
        if (manager.Red == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetBool("atacando", true);
            }
            else
            {
                anim.SetBool("atacando", false);
            }
        }

    }

     void Gravedad()
    {
        //Gravedad del Personaje
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    void Agacharse()
    {
      
        if(Input.GetKey(KeyCode.LeftControl))
        {
            controller.height = agachado;
            Crouch = true;
            if (isRuning == false)
            {
                speed = 2;
            }
        }
        else
        {
            controller.height = levantado;
            Crouch = false;
        }
        


    }

    void deslizar()
    {
        if(manager.Green == true)
        {
            if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKeyDown(KeyCode.LeftControl)))
            {
                canMove = false;
                speed = 10;

                move = transform.forward;


                Invoke("endDash", 0.4f);



            }
        }
      
    }
  

    void endDash()
    {
        canMove = true;
    }

  }
