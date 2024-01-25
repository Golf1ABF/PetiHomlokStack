using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverDetector : MonoBehaviour
{
    private GameObject HomlokSpawner;

    // Start is called before the first frame update
    void Start()
    {
        HomlokSpawner = GameObject.Find("HomlokSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        HomlokSpawner.SendMessage("setGameOver", true);
    }
}
