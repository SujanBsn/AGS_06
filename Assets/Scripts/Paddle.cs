using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        float control1 = 0.3f;
        float control2 = 9f;
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 rbpos = rb.transform.position;

            if (touchPos.x < rbpos.x-control1)
            {
                rb.velocity = Vector2.left * (moveSpeed+control2);
            }

            else if (touchPos.x > rbpos.x+control1)
            {
                rb.velocity = Vector2.right * (moveSpeed+control2);
            }

            else
            {
                rb.velocity = Vector2.zero;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
