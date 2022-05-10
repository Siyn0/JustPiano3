using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInRoomController : MonoBehaviour
{
    public float MoveSpeed = 1000f;
    public float JumpForce = 8000f;

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(MoveSpeed, 0f));
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(-MoveSpeed, 0f));
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, MoveSpeed));
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -MoveSpeed));
        }
    }
}
