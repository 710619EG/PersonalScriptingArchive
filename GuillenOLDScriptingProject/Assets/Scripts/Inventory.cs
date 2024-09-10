using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rocketPropelledGrenades;
        public float fuel;

        public Stuff(int bul, int gre, int rpg)
        {
            bullets = bul;
            grenades = gre;
            rocketPropelledGrenades = rpg;
        }
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        //Constructor
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rocketPropelledGrenades = 1;
        }
    }
    //Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);
    public Stuff myOtherStuff = new Stuff(50, 1.5f);
    void Start()
    {
        Debug.Log(myStuff.bullets);
    }
}
