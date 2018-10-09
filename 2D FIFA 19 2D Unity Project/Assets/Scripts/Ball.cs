﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public Text barcelonaScore;
    public Text realMadridScore;
    public int barcelonaGoals;
    public int realMadridGoals;
    public Text halfTimeText2;
    public int halfTimeInt;
    private string playerName;
    private GameObject player;
    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
        barcelonaGoals = 0;
        realMadridGoals = 0;
        halfTimeInt = 48;
        playerName = " ";
    }

    // Update is called once per frame
    //void Update () {
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LeftGoal" && System.Convert.ToInt32(halfTimeText2.text)< halfTimeInt) 
        {
            MusicSource.Play();
            realMadridGoals = realMadridGoals + 1;
            realMadridScore.text = realMadridGoals.ToString();
            playerName = "Soccer Ball";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(0f, 4.99f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(300f, 300f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-2f, 1.6f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(400f, 400f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-1.712295f, 8.075974f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(500f, 500f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-6.3484307f, -31.38052f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(600f, 600f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-21.385f, -18.42921f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(700f, 700f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-20.75458f, 26.77234f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(800f, 800f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-26.98068f, 5.192066f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(900f, 900f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.3266f, -30.772f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1000f, 1000f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.31985f, -11.07038f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1100f, 1100f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.41192f, 16.65977f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1200f, 1200f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-30.77896f, 35.43198f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1300f, 1300f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-40.1191277f, 7.92803f);

            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(10.018539f, 5.72928f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(6.47619f, 35.53289f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(6.12104f, -31.36489f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(18.72104f, -18.864894f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(18.62104f, 26.63511f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(24.9101f, 5.91086f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.212058f, -32.440592f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.0066f, -13.20157f);
            // player.transform.position = new Vector2(-57.26247f, 8.23597f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.053908f, 17.49875f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(26.332537f, 35.32505f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(39.74557f, 5.328654f);
        }
        else if (collision.gameObject.name == "GoalRight"&& System.Convert.ToInt32(halfTimeText2.text) < halfTimeInt)
        {
            MusicSource.Play();
            barcelonaGoals = barcelonaGoals + 1;
            barcelonaScore.text = barcelonaGoals.ToString();
            playerName = "Soccer Ball";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(0f, 4.99f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(300f, 300f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-12.94596f, 5.3f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(400f, 400f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-6.470272f, 35.46913f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(500f, 500f);
            playerName = "Coutinho2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-6.3484307f, -31.38052f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(600f, 600f);
            playerName = "Rakitic2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-21.385f, -18.42921f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(700f, 700f);
            playerName = "Vidal2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-20.75458f, 26.77234f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(800f, 800f);
            playerName = "Sergio2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-26.98068f, 5.192066f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(900f, 900f);
            playerName = "Roberto2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.3266f, -30.772f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1000f, 1000f);
            playerName = "Pique2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.31985f, -11.07038f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1100f, 1100f);
            playerName = "Umtiti2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-31.41192f, 16.65977f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1200f, 1200f);
            playerName = "Alba2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-30.77896f, 35.43198f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1300f, 1300f);
            playerName = "TerStegen3";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-40.1191277f, 7.92803f);

            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1.7731052f, 1.6141f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1.80619f, 8.73289f);
            playerName = "Benzema";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(6.12104f, -31.36489f);
            playerName = "Modric";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(18.72104f, -18.864894f);
            playerName = "Kroos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(18.62104f, 26.63511f);
            playerName = "Casemiro";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(24.9101f, 5.91086f);
            playerName = "Marcelo";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.212058f, -32.440592f);
            playerName = "Varane";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.0066f, -13.20157f);
            // player.transform.position = new Vector2(-57.26247f, 8.23597f);
            playerName = "Ramos";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(27.053908f, 17.49875f);
            playerName = "Carvajal";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(26.332537f, 35.32505f);
            playerName = "Courtois";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(39.74557f, 5.328654f);
        }
        else if (collision.gameObject.name == "LeftGoal" && System.Convert.ToInt32(halfTimeText2.text) > halfTimeInt)
        {
            MusicSource.Play();
            barcelonaGoals = barcelonaGoals + 1;
            barcelonaScore.text = barcelonaGoals.ToString();
            playerName = "Soccer Ball";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(0f, 4.99f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
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
        }
        else if (collision.gameObject.name == "GoalRight" && System.Convert.ToInt32(halfTimeText2.text) > halfTimeInt)
        {
            MusicSource.Play();
            realMadridGoals = realMadridGoals + 1;
            realMadridScore.text = realMadridGoals.ToString();
            playerName = "Soccer Ball";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(0f, 4.99f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Isco";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(300f, 300f);
            playerName = "Messi2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1.8f, 2.09f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(200f, 200f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(400f, 400f);
            playerName = "Suarez2";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(1.81973f, 7.919131f);
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
            player.transform.position = new Vector2(-13.7569f, 5.5741f);
            playerName = "Bale";
            player = GameObject.Find(playerName);
            player.transform.position = new Vector2(-6.62381f, 32.53289f);
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
        }
        //if(collision.gameObject.name == "Messi" && )
        //{

        //}
        //else if ()
        //{

        //}
    }
	//}
}
