using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 1000f;
    public float JumpForce = 8000f;

    private float JumpTime = 1f;
    private bool CanJump = true;
    private float LastJump = 0f;

    private void Update()
    {

        //TODO µØÃæ¼ì²â   ÉäÏß Layer
        //Ray2D ray = new Ray2D();//?

        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveSpeed, 0f));
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(-MoveSpeed, 0f));
        }


        if (CanJump)
        {
            if(Input.GetAxis("Jump") > 0)
            {
                CanJump = false;
                transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce));
                Debug.Log("Jump");
            }
        }
        else
        {
            if(LastJump < JumpTime)
            {
                LastJump += 0.01f;
            }
            else
            {
                LastJump = 0f;
                CanJump = true;
            }
        }
    }
}
