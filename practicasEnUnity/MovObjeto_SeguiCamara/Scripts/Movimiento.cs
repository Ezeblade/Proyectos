using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float speed = 0.5f;
    private void Rotate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0f, 0f, -speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0f, 0f, speed));
        }

    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(speed, 0f, 0f));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-speed, 0f, 0f));
        }
    }
    private void Update()
    {
        Rotate();
        Move();
    }
}