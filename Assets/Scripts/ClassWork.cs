using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassWork : MonoBehaviour
{
    int number1 = 5;
    int number2 = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (number1 > number2)
        {
            Debug.Log("number1 is bigger");
        }
        else
        {
            Debug.Log("number2 is bigger");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
