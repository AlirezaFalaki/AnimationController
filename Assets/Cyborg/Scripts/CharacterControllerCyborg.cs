using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerCyborg : MonoBehaviour
{
    public float Speed = 75.0f;
    Animator animator;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
       characterController = GetComponent<CharacterController>();
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        bool run = animator.GetBool("run");
        bool runLeft45 = animator.GetBool("runLeft45");
        bool runRight45 = animator.GetBool("runRight45");

        

       if(run | runLeft45 | runRight45)
       {
            Speed = 150.0f; 
            Vector3 move = new Vector3(hInput,0,vInput) * Speed * Time.deltaTime;
            characterController.Move(move); 
       }
       else
       {
            Speed = 65.0f;
            Vector3 move = new Vector3(hInput,0,vInput) * Speed * Time.deltaTime;
            characterController.Move(move); 
       }
       
    }
}
