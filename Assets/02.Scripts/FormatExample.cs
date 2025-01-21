using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("I am {0}. I am {1} years old.", "Iron Man", 55);   
        Debug.LogFormat("I am {0}. I am {1} years old.", "Super Man", 100); 
        Debug.LogFormat("I am {0}. You are not {0}. ", "Thor"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
