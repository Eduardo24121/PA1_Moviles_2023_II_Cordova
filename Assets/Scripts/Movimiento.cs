using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Rigidbody2D RB2D;
    public float JumpForce;

    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RB2D.velocity = Vector2.up * JumpForce;
        }
    }
}