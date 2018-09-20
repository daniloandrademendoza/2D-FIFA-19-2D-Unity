using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  //  float xInitial;
   // float yInitial;
    public float speed;
    public float speedBall;
    // Use this for initialization
    void Start()
    {
       // xInitial = this.transform.position.x;
       // yInitial = this.transform.position.y;
        speed = 5f;
        speedBall = .5f;
    }

    // Update is called once per frame
    void Update()
    {
       
        this.transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Soccer Ball")
        {
           
            Rigidbody2D ball = collision.gameObject.GetComponent<Rigidbody2D>();
            if (this.transform.position.x < collision.transform.position.x && Mathf.Abs(this.transform.position.y-collision.transform.position.y)<0.2)
            {
                ball.AddForce(transform.right * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.x > collision.transform.position.x && Mathf.Abs(this.transform.position.y - collision.transform.position.y) < 0.2)
            {
                ball.AddForce(-transform.right * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.y < collision.transform.position.y && Mathf.Abs(this.transform.position.x - collision.transform.position.x) < 0.2)
            {
                    ball.AddForce(transform.up * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.y > collision.transform.position.y && Mathf.Abs(this.transform.position.x - collision.transform.position.x) < 0.2)
            {
                ball.AddForce(-transform.up * speedBall, ForceMode2D.Impulse);
            }
         
        }
    }

}
