using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    private int plusOne = 1;
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number " +(i+plusOne) + " is named " + players[i].name);
        }
    }
}
