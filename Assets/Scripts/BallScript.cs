using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Rigidbody2D rigid;
    public Vector3 ballSpeed = new Vector3(4, 4, 0);

    public float score1 = 0;
    public float score2 = 0;

    public GUISkin guiskin;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = ballSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "wall-ver-p1") {
            score2 += 1;
        }

        if (collision.gameObject.name == "wall-ver-p2") {
            score1 += 1;
        }

        gameObject.transform.position = new Vector3(0, 3, -2);
        rigid.velocity = ballSpeed;
    }

    private void OnGUI()
    {
        GUI.skin = guiskin;
        GUI.Label(new Rect(Screen.width / 2 - 70, 15, 100, 100), "" + score1);
        GUI.Label(new Rect(Screen.width / 2 + 70, 15, 100, 100), "" + score2);
    }
}
