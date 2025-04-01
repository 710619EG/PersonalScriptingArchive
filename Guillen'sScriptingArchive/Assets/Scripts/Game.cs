using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerProperties myPlayer = new PlayerProperties();

        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
