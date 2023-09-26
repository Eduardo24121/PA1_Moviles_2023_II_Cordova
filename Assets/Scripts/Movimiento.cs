using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Rigidbody2D RB2D;
    public float JumpForce;
    private float HoldForce = 3.5f;
    private bool isJumping = false;

    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isJumping = true;
                RB2D.velocity = Vector2.up * JumpForce;
            }
            else if (touch.phase == TouchPhase.Stationary && isJumping)
            {

                RB2D.velocity = Vector2.up * HoldForce;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isJumping = false;
            }
        }
    }
}