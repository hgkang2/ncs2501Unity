using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    // Start is called before the first frame update

    static public bool staticVariable = true;
    private int m_GlobalVariable = 1;
    public int abCde = 100;
    void Start()
    {
        int localVariable1 = 1; //지역변수

        int localVariable2; //값을 할당하지 않은 지역변수
        
        //Debug.Log(localVariable2.ToString());
        LocalVariable(1 /*매개변수*/);
    }
    void LocalVariable(int parameter/*매개변수*/)
    {
        float localVariable = parameter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
