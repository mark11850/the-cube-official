using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    int chp = 100;
    public int mhp = 100;
  
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
            takedamage(25);

    }

    internal void takedamage(int damage)
    {
        chp -= damage;
        print("ouch, yoou hurt me, my health is now" + chp);
    }

    internal int whatsyourmaxhealth()
    {
        return mhp;
    }
}
