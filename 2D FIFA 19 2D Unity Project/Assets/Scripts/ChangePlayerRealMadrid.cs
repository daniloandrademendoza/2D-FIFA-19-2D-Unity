using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangePlayerRealMadrid : MonoBehaviour
{
    public GameObject player;
    public int selectedPlayer;
    public string playerName;
    //public Renderer rend;
    // Use this for initialization
    //public Rigidbody2D rigidBody;
    //public GameObject player5;
   // public int selectedPlayer5;
    //public string playerName5;

    void Start()
    {

        selectedPlayer = 0;
        playerName = "Isco";
        player = GameObject.Find(playerName);
        //player = 
        //  player = Player.;
        //selectedPlayer5 = 0;
       // playerName5 = "Messi";
       // player5 = GameObject.Find(playerName5);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (selectedPlayer <= 11)
            {
                selectedPlayer++;
            }
            else
            {
                selectedPlayer = 1;
            }


            for (int i = 1; i <=11; i++)
            {
                if (i == selectedPlayer && i == 1)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 2)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 3)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 4)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 5)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                }
                else if (i == selectedPlayer && i == 6)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                }
                else if (i == selectedPlayer && i == 7)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 8)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 9)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;

                }
                else if (i == selectedPlayer && i == 10)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;


                }
                else if (i == selectedPlayer && i == 11)
                {

                    playerName = "Isco";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Bale";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Benzema";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Modric";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Kroos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Casemiro";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Marcelo";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Varane";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Ramos";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Carvajal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = false;
                    playerName = "Courtois";
                    player = GameObject.Find(playerName);
                    player.GetComponent<PlayerRealMadrid>().enabled = true;


                }

            }
        }
        // Update is called once per frame

        //if (Input.GetKeyDown(KeyCode.X))
        //{
        //    if (selectedPlayer5 <= 11)
        //    {
        //        selectedPlayer5++;
        //    }
        //    else
        //    {
        //        selectedPlayer5 = 1;
        //    }
        //    for (int j = 1; j <= 11; j++)
        //    {
        //        if (j == selectedPlayer5 && j == 1)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 2)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 3)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 4)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 5)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 6)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 7)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 8)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 9)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 10)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //        }
        //        else if (j == selectedPlayer5 && j == 11)
        //        {
        //            playerName5 = "Messi2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Suarez2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Coutinho2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Rakitic2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Vidal2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Sergio2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Roberto2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Pique2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Umtiti2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "Alba2";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = false;
        //            playerName5 = "TerStegen3";
        //            player5 = GameObject.Find(playerName5);
        //            player5.GetComponent<Player>().enabled = true;
        //        }
        //    }
        //}

    }

}

