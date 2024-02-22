using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    
    void Start()
    {
        graphic.sprite = standard;
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held
        bool 
    }
}
