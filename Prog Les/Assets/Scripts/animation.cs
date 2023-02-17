using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach this script to a GameObject with an Animator component attached.
//For this example, create parameters in the Animator and name them “Crouch” and “Jump”
//Apply these parameters to your transitions between states

//This script allows you to trigger an Animator parameter and reset the other that could possibly still be active. Press the up and down arrow keys to do this.

public class animation : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.W))
        {
            //Reset the "Crouch" trigger
            //m_Animator.ResetTrigger("walk");

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("walk");
        }

        if (Input.GetKey(KeyCode.S))
        {
            //Reset the "Jump" trigger
            //m_Animator.ResetTrigger("walk");

            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            m_Animator.SetTrigger("stand");
        }
    }
}