using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangePlayerRealMadrid : MonoBehaviour
{
    public GameObject player;
    public int selectedPlayer;
    public string playerName;
    void Start()
    {
        selectedPlayer = 0;
        playerName = "Isco";
        player = GameObject.Find(playerName);
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
    }

}

