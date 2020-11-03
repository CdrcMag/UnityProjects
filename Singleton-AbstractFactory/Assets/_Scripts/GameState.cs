using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    //Instance du singleton
    public static GameState Instance;

    //Variables contenue dans le singleton
    public bool isRunning = true;

    //Setup
    private void Awake()
    {
        Instance = this;
        if (Instance == null)
        {
            Instance = GameObject.FindObjectOfType<GameState>();
            if (Instance == null)
            {
                GameObject container = new GameObject("GameState");
                Instance = container.AddComponent<GameState>();
            }
        }
    }


    
}
