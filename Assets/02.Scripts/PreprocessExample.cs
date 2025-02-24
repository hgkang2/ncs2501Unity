#define DEBUG_TEST

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreprocessExample : MonoBehaviour
{
    //bool isTest = false;
    void Start()
    {
        //#if DEBUG_TEST
        #if (DEBUG_TEST && !UNITY_ANDROID)
        //if(isTest)
        //{
            Debug.Log("Password:12345");
        //}
        #elif(!DEBUG_TEST && UNITY_ANDROID)
        Debug.Log("");
        #elif(DEBUG_TEST && UNITY_ANDROID)
        Debug.Log("");
        #else
        Debug.Log("");
        #endif
    }

    
}