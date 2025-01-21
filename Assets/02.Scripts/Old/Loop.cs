using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Loop : MonoBehaviour
{
    int numEnemies =3;
    // Start is called before the first frame update
    void Start()
    {
       ForeachLoop();
    }
    
    void ForLoop()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

    void whileLoop()
    {
        int cupInTheSink = 4;
        while (cupInTheSink > 0)
        {
            //Debug.Log("I've washed a cup!");
            cupInTheSink--;
        }

        cupInTheSink = 4;
        for(int i = cupInTheSink; i>0; i-- )
        {
            Debug.Log("I've washed a cup!");
            
        }
    }

    void Dowhile()
    {
        bool shouldContinue = false;
        do
        {
            print("Hello World");
            
        }while(shouldContinue==true);
    }

    void ForeachLoop()
    {
        string[] strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print (item);
        }

        for(int i =0 ; i <strings.Length; i++)
        {
            Debug.Log(strings[i]);

        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
