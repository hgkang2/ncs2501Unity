using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using UnityEngine;

public class StandardDateTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DateTime dt = new DateTime(2025, 01, 22, 13, 37, 34); 
        Debug.Log(dt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "한국 {0:d}", dt));
        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:D}", dt));
        Debug.Log(dt.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:f}", dt));
        Debug.Log(dt.ToString("U", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:y}", dt));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
