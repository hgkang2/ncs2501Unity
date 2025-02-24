using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    // Start is called before the first frame update
    enum State {make,stop};
    State state = State.make;
    public GameObject target;
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
        state = State.make;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(state == State.make)
            {
                CancelInvoke("SpawnObject");
                state = State.stop;
            }
            if(state == State.stop)
            {
                CancelInvoke("SpawnObject",1,1);
                state = State.make;
            }
            CancelInvoke("spawnObject");
        }
    }

    private void StartInvoke(string v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    private void CancelInvoke(string v1, int v2, int v3)
    {
        throw new System.NotImplementedException();
    }

    // Update is called once per frame
    void SpawnObject()
    {
        float x = UnityEngine.Random.Range(-2.0f, 2.0f);
        float z = UnityEngine.Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 3, z), Quaternion.identity);
    }

}

