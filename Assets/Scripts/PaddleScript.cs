using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public bool isPlayer1 = true;
    Rigidbody2D rigid;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveUp2 = KeyCode.UpArrow;
    public KeyCode moveDown2 = KeyCode.DownArrow;
    public float speed = 10.0f;
    public float boundY = 3.0f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isPlayer1)
        {
            var vel = rigid.velocity;
            if (Input.GetKey(moveUp))
            {
                vel.y = speed;
            }
            else if (Input.GetKey(moveDown))
            {
                vel.y = -speed;
            }
            else
            {
                vel.y = 0;
            }
            rigid.velocity = vel;

            var pos = transform.position;
            if (pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if (pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            transform.position = pos;
        }

        else
        {
            var vel = rigid.velocity;
            if (Input.GetKey(moveUp2))
            {
                vel.y = speed;
            }
            else if (Input.GetKey(moveDown2))
            {
                vel.y = -speed;
            }
            else
            {
                vel.y = 0;
            }
            rigid.velocity = vel;

            var pos = transform.position;
            if (pos.y > boundY)
            {
                pos.y = boundY;
            }
            else if (pos.y < -boundY)
            {
                pos.y = -boundY;
            }
            transform.position = pos;
        }
    }
}
