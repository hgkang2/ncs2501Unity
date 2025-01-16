using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeT = 85.0f;
    float hotLimitT = 70.0f;
    float coldLimitT = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        TTest();
    }
    void TTest()
    {
        if (coffeeT>hotLimitT)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeT < coldLimitT)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
