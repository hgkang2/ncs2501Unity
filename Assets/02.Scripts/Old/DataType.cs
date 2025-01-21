using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var i = 1;
        var f = 2f;
        var c = 'c';
        var s = "string";
        // 아래는 에러남
        //var v;

        //int age = 46;
        //int brother =2;
        int age = 46, brother = 2;
        float f1 = 1.0f, f2 = 2.3f;
        int i1, i2 = 4, i3;
        var v1 = 1; var v2 = 2;

        string str = new string("abc");

        int number1;
        number1 =1;
        int number2 =2;
        float number3 = 3f, number4 = 4f;
        bool isBool = true;
        Debug.Log(number1.ToString()); 
        Debug.Log(number2.ToString());
        Debug.Log(number3.ToString()); 
        Debug.Log(number4.ToString()); 
        Debug.Log(isBool.ToString());

        //값을 지정하지 않은 지역 변수는 사용하면 에러
        // Debug.Log(i1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
