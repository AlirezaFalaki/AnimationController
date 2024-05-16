using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;
    bool space_state;
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
        
        // left arc walking
        if(w_state)
           if (a_state)
                animator.SetBool("walkLeftArc",true);
        else
           animator.SetBool("walkLeftArc",false);

        // handling forward walking with "w" key 
        if(w_state)
           animator.SetBool("isWalking",true);
        else
            animator.SetBool("isWalking",false);

        // handling Right walking with "d" key 
        if(d_state)
           animator.SetBool("walkRight",true);
        else
            animator.SetBool("walkRight",false);

        // handling Left walking with "a" key 
        if(a_state)
           animator.SetBool("walkLeft",true);
        else
            animator.SetBool("walkLeft",false);

        // handling Backward walking with "s" key 
        if(s_state)
           animator.SetBool("Backward",true);
        else
            animator.SetBool("Backward",false);

        // handling Sprint with "left shift" key 
        if(w_state && shift_state)
           animator.SetBool("isRunning",true);
        else
            animator.SetBool("isRunning",false);
        
        // handling Jump with "space" key 
        
        
    }

}
