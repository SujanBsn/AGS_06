using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    public float bounceSpeed;
    //public Vector2 velocity;
    bool firsttouch= false;
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
        rb.velocity = bounceSpeed * (rb.velocity.normalized);
        //if (velocity.x != 4 || velocity.y != 4)
        //{ rb.velocity = velocity; }
        if (!firsttouch)
        {
            if (Input.anyKeyDown)
            {
                Startbounce();
                firsttouch = true;
                GameManager.instance.GameStart();
            }
        }
        //if(firsttouch==true)
          //  { GameManager.instance.GameContinue(); }
    }

    void Startbounce()
    {
        Vector2 randomDirection = new Vector2(Random.Range(-1, 1), 1);
        rb.AddForce(randomDirection * bounceForce,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("Fall_check"))
        {
            GameManager.instance.Restart();
        }

      else if (collision.gameObject.CompareTag("Paddle"))
        {
            GameManager.instance.Scoreup();
        }
    }
}
