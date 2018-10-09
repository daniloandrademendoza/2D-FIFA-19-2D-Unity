using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayersBarcelona : MonoBehaviour {
    public GameObject player3;
    public int selectedPlayer;
    public string playerName;
    //public Renderer rend;
    // Use this for initialization
    //public Rigidbody2D rigidBody;
    void Start()
    {

        selectedPlayer = 0;
        playerName = "Messi2";
        player3 = GameObject.Find(playerName);
        //player = 
        //  player = Player.;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (selectedPlayer <= 11)
            {
                selectedPlayer++;
            }
            else
            {
                selectedPlayer = 1;
            }


            for (int i = 1; i <= 11; i++)
            {
                if (i == selectedPlayer && i == 1)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 2)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 3)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 4)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 5)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                }
                else if (i == selectedPlayer && i == 6)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                }
                else if (i == selectedPlayer && i == 7)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 8)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 9)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;

                }
                else if (i == selectedPlayer && i == 10)
                {


                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;


                }
                else if (i == selectedPlayer && i == 11)
                {

                    playerName = "Messi2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Suarez2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Coutinho2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Rakitic2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Vidal2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Sergio2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Roberto2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Pique2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Umtiti2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "Alba2";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = false;
                    playerName = "TerStegen3";
                    player3 = GameObject.Find(playerName);
                    player3.GetComponent<Player>().enabled = true;

                }

            }
        }
        // Update is called once per frame
    }

}
