using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountingTimer : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private float fullTime;
    private float fullTimePlus;
    private float halfTime;
    private float halfTimePlus;
    private int minutes;
    private int seconds;
    private float elapsed;
    public Text time;
    private string playerName;
    private GameObject player;
    private float elapsed2;
    public Text barcelonaScore;
    public Text realMadridScore;
    private int barcelonaGoals;
    private int realMadridGoals;
    public Text halfTimeText;
    // Update is called once per frame

    private void Start()
    {
        elapsed = 0f;
        elapsed2 = 0f;
        halfTime = 2880f;
        halfTimePlus = 2900f;
        fullTime= 5580f;
        fullTimePlus = 5600f;
        minutes = 0;
        seconds = 0;
        playerName = " ";
        barcelonaGoals = 0;
        realMadridGoals = 0;
       //timeFloat = 0f;

    }
    private void Update () {
            elapsed = elapsed + Time.smoothDeltaTime*50; //*100
            minutes = Mathf.FloorToInt(elapsed / 60F);
            seconds = Mathf.FloorToInt(elapsed - minutes * 60);
            //time.text = elapsed.ToString();
            time.text = string.Format("{0:0}:{1:00}", minutes, seconds);
        halfTimeText.text = minutes.ToString();
        

        //Debug.Log(elapsed.ToString());
        // Debug.Log(time.text);
        //timeFloat = float.Parse(time.text);
        // Debug.Log(timeFloat);
        //Debug.Log(elapsed);
        // Debug.Log(time.text);
        if (elapsed>=halfTime && elapsed < halfTimePlus)
            {
            elapsed = elapsed + Time.smoothDeltaTime*50;//*100
            minutes = Mathf.FloorToInt(elapsed / 60F);
            seconds = Mathf.FloorToInt(elapsed - minutes * 60);
            //time.text = elapsed.ToString();
            time.text = string.Format("{0:0}:{1:00}", minutes, seconds);
            halfTimeText.text = minutes.ToString();
            //timeFloat = float.Parse(time.text);
            //Debug.Log(timeFloat);
            //Debug.Log(elapsed.ToString());
            //Debug.Log(elapsed.ToString());
            //Debug.Log(time.text);
            playerName = "Soccer Ball";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(0f, 4.99f);
            //playerName = "Messi";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Suarez";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Coutinho";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Rakitic";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Vidal";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Sergio";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Roberto";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Pique";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Umtiti";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Alba";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "TerStegen2";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Isco";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Bale";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Benzema";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Modric";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Kroos";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Casemiro";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Marcelo";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Varane";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Ramos";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Carvajal";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            //playerName = "Courtois";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            //player.GetComponent<BoxCollider2D>().enabled = false;
            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(300f, 300f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(9.1f, 5.6f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(400f, 400f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(6.43f, 35.66913f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(500f, 500f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(6.02157f, -31.3802f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(600f, 600f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(19.015f, -18.83671f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(700f, 700f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(18.74543f, 26.77234f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(800f, 800f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(25.11931f, 5.992066f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(900f, 900f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.1734f, -32.272f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1000f, 1000f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(26.98015f, -13.36288f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1100f, 1100f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.011485f, 17.66856f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1200f, 1200f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.22104f, 35.33197f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1300f, 1300f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(39.82104f, 5.23197f);

            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-1.986895f, 1.2541f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-1.77381f, 8.03289f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-6.93896f, -31.36489f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-23.37896f, -19.364894f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-22.77896f, 25.63511f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-25.7899f, 4.91086f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.48794f, -32.040591f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.13542f, -14.99472f);
           // player.transform.position = new Vector2(-57.26247f, 8.23597f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.14609f, 17.19875f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.00202f, 34.14022f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-39.85443f, 5.128654f);
            //player.transform.position = new Vector2(-54.19292f, 5.964026f);

            //playerName = "Messi";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Suarez";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Coutinho";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Rakitic";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Vidal";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Sergio";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Roberto";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Pique";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Umtiti";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Alba";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "TerStegen2";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Isco";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Bale";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Benzema";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Modric";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Kroos";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Casemiro";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Marcelo";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Varane";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Ramos";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Carvajal";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //playerName = "Courtois";
            //player = GameObject.Find(playerName);
            //player.GetComponent<BoxCollider2D>().enabled = true;
            //Debug.Log(elapsed);
            //Debug.Log(time.text);
        }
        else if (elapsed >=fullTime && elapsed < fullTimePlus)
        {
            Debug.Log(elapsed);
            Debug.Log(time.text);
            elapsed = elapsed + Time.smoothDeltaTime*50;//*100
            minutes = Mathf.FloorToInt(elapsed / 60F);
            seconds = Mathf.FloorToInt(elapsed - minutes * 60);
            //time.text = elapsed.ToString();
            time.text = string.Format("{0:0}:{1:00}", minutes, seconds);
            halfTimeText.text = minutes.ToString();
            //timeFloat = float.Parse(time.text);
            //Debug.Log(timeFloat);
            //Debug.Log(elapsed.ToString());
            barcelonaGoals = System.Convert.ToInt32(barcelonaScore.text);
            realMadridGoals = System.Convert.ToInt32(realMadridScore.text);
           // Debug.Log(barcelonaGoals);
           // Debug.Log(realMadridGoals);
           
            if(barcelonaGoals>realMadridGoals)
            {
                SceneManager.LoadScene("BarcelonaWon");
                
            }
            else if(realMadridGoals>barcelonaGoals)
            {
                SceneManager.LoadScene("RealMadridWon");
            }
           else if(barcelonaGoals==realMadridGoals)
            {
                SceneManager.LoadScene("Tied");
            }
            
            
            
            
            
            
            
            
            
            
            // elapsed = elapsed + Time.smoothDeltaTime * 100;
           //minutes = Mathf.FloorToInt(elapsed / 60F);
          //  seconds = Mathf.FloorToInt(elapsed - minutes * 60);
           // time.text = string.Format("{0:0}:{1:00}", minutes, seconds);

        }
	}
}
