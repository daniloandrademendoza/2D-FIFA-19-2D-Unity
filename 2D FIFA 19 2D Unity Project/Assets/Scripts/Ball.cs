using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    // Use this for initialization
    void Start () {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    //void Update () {
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LeftGoal" || collision.gameObject.name == "GoalRight")
        {
            MusicSource.Play();
        }
    }
	//}
}
