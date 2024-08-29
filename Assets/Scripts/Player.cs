using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int playerHealth;
    public int playerScore;

    public void Start()
    {
        playerName = "dani";
        playerHealth = 4;
        playerScore = 24;
        Debug.Log("printing something");

    }

}
