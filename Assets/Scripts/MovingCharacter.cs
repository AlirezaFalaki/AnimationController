using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour
{
    public float Speed = 1.5f;
    // Start is called before the first frame update
    public float jumpAmount = 1.0f;
    private CharacterController characterController;
    private Animator animator;
    private Rigidbody rigidBody;
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        bool run = animator.GetBool("isRunning");
       

        if (run){
            Speed = 4.0f;
            Vector3 move = new Vector3(hInput,0 ,vInput);
            characterController.Move(move * Speed * Time.deltaTime);
        }
        else{
            Speed = 1.5f;
            Vector3 move = new Vector3(hInput,0 ,vInput);
            characterController.Move(move * Speed * Time.deltaTime);
        }
        //if (jump)
    }
}
