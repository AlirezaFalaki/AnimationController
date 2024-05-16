using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationControllerCyborg : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool w_state = Input.GetKey("w");
        bool d_state = Input.GetKey("d");
        bool a_state = Input.GetKey("a");
        bool s_state = Input.GetKey("s");
        bool shift_state = Input.GetKey("left shift");

        // walk forward
        if (w_state)
        {
            if(shift_state)
            {
                if(d_state)
                {
                    animator.SetBool("runRight45",true);
                }
                else
                {
                    animator.SetBool("runRight45",false);
                }
                if(a_state)
                {
                    animator.SetBool("runLeft45",true);
                }
                else
                {
                    animator.SetBool("runRight45",false);
                }
                animator.SetBool("run",true);
            }
            else
            {
                animator.SetBool("run",false);
            }
                
                
            animator.SetBool("isWalking",true);
        }  
        else
        {
            animator.SetBool("isWalking",false);
            animator.SetBool("run",false);
            animator.SetBool("runRight45",false);
            animator.SetBool("runLeft45",false);
        }
            

        // walk right
        if (d_state)
        {
            if (w_state)
            {
                if(shift_state)
                {
                    animator.SetBool("runRight45",true);
                }
                else
                {
                    animator.SetBool("runRight45",false);
                }
                animator.SetBool("walkRight45",true);
            } 
            else
            {
                animator.SetBool("walkRight45",false);
                animator.SetBool("runRight45",false);
            }
                
           animator.SetBool("walkRight",true);
        }
        else
            animator.SetBool("walkRight",false);

        //walk Right
        if ((d_state && w_state) || (d_state && a_state))
           animator.SetBool("walkRight45",true);
        else
            animator.SetBool("walkRight45",false);


        // walk left
         if (a_state)
        {
            if (w_state)
            {
                if(shift_state)
                {
                    animator.SetBool("runLeft45",true);
                }
                else
                {
                    animator.SetBool("runLeft45",false);
                }
                animator.SetBool("walkLeft45",true);
            } 
            else
            {
                animator.SetBool("walkLeft45",false);
                animator.SetBool("runLeft45",false);
            }
                
           animator.SetBool("walkLeft",true);
        }
        else
            animator.SetBool("walkLeft",false);


        //walk left
        if ((a_state && w_state) || (s_state && a_state))
           animator.SetBool("walkLeft45",true);
        else
            animator.SetBool("walkLeft45",false);

        //backward

        if(s_state)
            animator.SetBool("backward",true);
        else
            animator.SetBool("backward",false);


    }
}
