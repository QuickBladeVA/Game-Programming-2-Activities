using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Enumeration Days;
    // Start is called before the first frame update
    void Start()
    {
        switch (Days)
        {
         case Enumeration.Monday: Debug.Log("Monday");break;
         case Enumeration.Tuesday: Debug.Log("Tuesday");break;
         case Enumeration.Wednesday: Debug.Log("Wednesday");break;
         case Enumeration.Thursday: Debug.Log("Thursday");break;
         case Enumeration.Friday: Debug.Log("Friday");break;
         case Enumeration.Saturday: Debug.Log("Saturday");break;
         case Enumeration.Sunday: Debug.Log("Sunday");break;
        }
    }
}

