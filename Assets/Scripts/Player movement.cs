
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public float jumpHeight = 5f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Animator animator;
    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float currentSpeed = walkSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
        }

        Vector3 move =
            transform.right * x +
            transform.forward * z;

        controller.Move(move * currentSpeed * Time.deltaTime);

        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = 15f;
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        float movementAmount = move.magnitude;

        if (animator != null)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetFloat("speed", 2f); // Running
            }
            else if (movementAmount > 0)
            {
                animator.SetFloat("speed", 1f); // Walking
            }
            else
            {
                animator.SetFloat("speed", 0f); // Idle
            }
        }
        Debug.Log(controller.isGrounded);
    }
}