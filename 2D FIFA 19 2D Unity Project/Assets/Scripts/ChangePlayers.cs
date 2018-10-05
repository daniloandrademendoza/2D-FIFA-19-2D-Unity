using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangePlayers : MonoBehaviour
{
   public GameObject player;
    public int selectedPlayer;
    public string playerName;
    //public Renderer rend;
    // Use this for initialization
    //public Rigidbody2D rigidBody;
    void Start()
    {

        selectedPlayer = 0;
        playerName = "Messi";
        player = GameObject.Find(playerName);
        //player = 
        //  player = Player.;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedPlayer <12 )
            {
                selectedPlayer++;
            }
            else
            {
                selectedPlayer = 1;
            }


            for (int i = 1; i <12; i++)
            {
                if (i == selectedPlayer && i == 1)
                {
                    
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 2)
                {
                  
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 3)
                {
             
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 4)
                {
                    
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 5)
                {
                  
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                }
                else if (i == selectedPlayer && i == 6)
                {
                    
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 7)
                {
                
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 8)
                {
                    
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 9)
                {
                    
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 10)
                {

                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;


                }
                else if (i == selectedPlayer && i == 11)
                {

                    playerName = "Messi";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Suarez";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Vidal";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Sergio";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Roberto";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Pique";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "Alba";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen2";
                    player = GameObject.Find(playerName);
                    player.GetComponent<Player>().enabled = true;


                }

            }
            }
        // Update is called once per frame
    }

    
}
