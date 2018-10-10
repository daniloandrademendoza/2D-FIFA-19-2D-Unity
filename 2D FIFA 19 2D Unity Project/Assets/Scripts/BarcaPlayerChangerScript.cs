using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BarcaPlayerChangerScript : MonoBehaviour
{
    public GameObject player5;
    public int selectedPlayer5;
    public string playerName5;
     void Start()
    {
        selectedPlayer5 = 0;
        playerName5 = "Messi2";
        player5 = GameObject.Find(playerName5);
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            if(selectedPlayer5<=11)
            {
                selectedPlayer5++;
            }
            else
            {
                selectedPlayer5 = 1;
            }
            for(int j=1; j<=11;j++)
            {
                if(j==selectedPlayer5 && j==1)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5= "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if(j==selectedPlayer5 && j==2)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 3)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 4)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 5)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 6)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 7)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 8)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 9)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 10)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                }
                else if (j == selectedPlayer5 && j == 11)
                {
                    playerName5 = "Messi2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Suarez2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Coutinho2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Rakitic2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Vidal2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Sergio2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Roberto2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Pique2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Umtiti2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "Alba2";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = false;
                    playerName5 = "TerStegen3";
                    player5 = GameObject.Find(playerName5);
                    player5.GetComponent<Player>().enabled = true;
                }
            }
            }
        }

    }


