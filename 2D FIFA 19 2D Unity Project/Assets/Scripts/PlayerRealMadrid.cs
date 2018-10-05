using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRealMadrid : MonoBehaviour {

    //  float xInitial;
    // float yInitial;
    public float speed;
    public float speedBall;
    // public AudioClip MusicClip;
    //public AudioSource MusicSource;
    // public GameObject playerName;
    // Use this for initialization
    private Rigidbody2D theRB;
    void Start()
    {
        // xInitial = this.transform.position.x;
        // yInitial = this.transform.position.y;
        speed = 50f;
        speedBall = 8f;
        theRB = GetComponent<Rigidbody2D>();
        // MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {

        //this.transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, speed * Input.GetAxis("Vertical") * Time.deltaTime, 0f);
        if(Input.GetKey(KeyCode.I))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, speed);
        }
        else if(Input.GetKey(KeyCode.J))
        {
            theRB.velocity = new Vector2(-speed, theRB.velocity.y);
        }
        else if(Input.GetKey(KeyCode.K))
        {
            theRB.velocity = new Vector2(theRB.velocity.x, -speed);
        }
        else if(Input.GetKey(KeyCode.L))
        {
            theRB.velocity = new Vector2(speed, theRB.velocity.y);
        }
        else
        {
            theRB.velocity = new Vector2(0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Soccer Ball")
        {

            Rigidbody2D ball = collision.gameObject.GetComponent<Rigidbody2D>();
            if (this.transform.position.x < collision.transform.position.x && Mathf.Abs(this.transform.position.y - collision.transform.position.y) < 0.3)
            {
                ball.AddForce(transform.right * speedBall, ForceMode2D.Impulse);
                // MusicSource.Play();
            }
            else if (this.transform.position.x > collision.transform.position.x && Mathf.Abs(this.transform.position.y - collision.transform.position.y) < 0.3)
            {
                ball.AddForce(-transform.right * speedBall, ForceMode2D.Impulse);
                // MusicSource.Play();
            }
            else if (this.transform.position.y < collision.transform.position.y && Mathf.Abs(this.transform.position.x - collision.transform.position.x) < 0.3)
            {
                ball.AddForce(transform.up * speedBall, ForceMode2D.Impulse);
                //  MusicSource.Play();
            }
            else if (this.transform.position.y > collision.transform.position.y && Mathf.Abs(this.transform.position.x - collision.transform.position.x) < 0.3)
            {
                ball.AddForce(-transform.up * speedBall, ForceMode2D.Impulse);
                //   MusicSource.Play();
            }
            else if (this.transform.position.y < collision.transform.position.y && this.transform.position.x < collision.transform.position.x)
            {
                ball.AddForce((transform.up + transform.right) * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.y > collision.transform.position.y && this.transform.position.x < collision.transform.position.x)
            {
                ball.AddForce((-transform.up + transform.right) * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.y > collision.transform.position.y && this.transform.position.x > collision.transform.position.x)
            {
                ball.AddForce((-transform.up + -transform.right) * speedBall, ForceMode2D.Impulse);
            }
            else if (this.transform.position.y < collision.transform.position.y && this.transform.position.x > collision.transform.position.x)
            {
                ball.AddForce((transform.up + -transform.right) * speedBall, ForceMode2D.Impulse);
            }

        }
        // if (collision.gameObject.name == "LeftGoal" || collision.gameObject.name == "GoalRight")
        // {
        //   MusicSource.Play();
        //}
    }
}
