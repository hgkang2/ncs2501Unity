using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumExample : MonoBehaviour
{
        enum EnumExample1 {e0,e1,e2}
        enum EnumExample2 {e0 = 5, e1, e2 =10}
        int[] i1 = new int []{1,2,4};
    private object daynumber;
    private object workingDay;

    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum Month : byte { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    // Start is called before the first frame update
    void Start()
    {
        Day today = Day.Wednesday;
        int daynumber = (int)today;
        Debug.Log($"{today} is day number {daynumber}." );
        

        Month thisMonth = Month.Jan;
        byte monthNumber = (byte)thisMonth;
        Debug.LogFormat($"{thisMonth} is month number {monthNumber}.");
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
