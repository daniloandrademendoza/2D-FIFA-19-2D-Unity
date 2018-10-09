using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  //  float xInitial;
   // float yInitial;
    public float speed;
    public float speedBall;
    private string playerName;
    private string minName;
    private GameObject player;
    private double minDistance;
    private GameObject player2;
   // public AudioClip MusicClip;
    //public AudioSource MusicSource;
   // public GameObject playerName;
    // Use this for initialization
    void Start()
    {
       // xInitial = this.transform.position.x;
       // yInitial = this.transform.position.y;
        speed = 50f;
        speedBall = 8f;
        name = " ";
        
        minDistance = 500;
        minName = " ";
        playerName = " ";
       // MusicSource.clip = MusicClip;
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
            if (this.transform.position.x < collision.transform.position.x && Mathf.Abs(this.transform.position.y-collision.transform.position.y)<0.3)
            {
                //if (this.gameObject.name == "Messi" && Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Q))
                //{
                //    this.GetComponent<Player>().enabled = false;
                //    playerName = "Suarez";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Coutinho";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Rakitic";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Vidal";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Sergio";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Roberto";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Pique";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Umtiti";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "Alba";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    playerName = "TerStegen2";
                //    player = GameObject.Find(playerName);
                //    if (System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2)) < minDistance && this.transform.position.x < player.transform.position.x && Mathf.Abs(this.transform.position.y - player.transform.position.y) < 1)
                //    {
                //        minDistance = System.Math.Sqrt(Mathf.Pow(this.transform.position.x - player.transform.position.x, 2) + Mathf.Pow(this.transform.position.y - player.transform.position.y, 2));
                //        minName = playerName;
                //    }
                //    else
                //    {
                //        player.GetComponent<Player>().enabled = false;
                //    }
                //    name = "Soccer Ball";
                //    player = GameObject.Find(name);
                //    player2 = GameObject.Find(minName);
                //    player.transform.position = new Vector2(player2.transform.position.x + 3, player2.transform.position.y);
                //    player2.GetComponent<Player>().enabled = true;
                //}
                //else if (this.gameObject.name == "Messi" && Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Q))
                //{

                //}
                //else if (this.gameObject.name == "Messi" && Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Q))
                //{

                //}
                //else if(this.gameObject.name == "Messi" && Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.Q))
                //{

                //}
                //else
                //{
                    ball.AddForce(transform.right * speedBall, ForceMode2D.Impulse);
               // }
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
            else if(this.transform.position.y <collision.transform.position.y && this.transform.position.x < collision.transform.position.x)
            {
                ball.AddForce((transform.up+transform.right) * speedBall, ForceMode2D.Impulse);
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
