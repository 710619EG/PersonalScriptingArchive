using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    /*
    public Image graphic;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;
    
   Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    */
    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");
        /*
        if(down)

        */
    }
}
