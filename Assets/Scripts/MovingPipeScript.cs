using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipeScript : MonoBehaviour
{
    public GameObject pipe; //coba pake rigidbody ball gabisa mantul
    public float speed = 1.0f;

    //Mathf.PingPong(float time, float length)
    //digunakan untuk melakukan gerakan berulang

    //Mathf.Lerp (min, max, Mathf.Pingpong(Time.time, 1));
    //digunakan untuk memodifikasi fungsi Mathf.PingPong() untuk menentukan posisi yg kita mau
    //min = batas posisi awal, max = batas posisi akhir
    public void Update()
    {
        float y =  Mathf.Lerp (-2, -8, Mathf.PingPong(Time.time * speed, 1));
        pipe.transform.position = new Vector3(0, y, -2);
    }

}
