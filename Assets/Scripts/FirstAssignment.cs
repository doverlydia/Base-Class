using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAssignment : MonoBehaviour
{
    void Start()
    {
        FirstMethod(10);
        SecondMethod(25);
        ThirdMethod(0);
    }
// perfect
    void FirstMethod(int firstNum)
    {
        firstNum += 5;
        Debug.Log(firstNum);
        return;
    }
// perfect
    void SecondMethod(int secondNum)
    {
        if (secondNum == 25)
        {
            Debug.Log("25 is a nice number, i guess");
        }
        else
        {
            Debug.Log($"{secondNum} cool alright");
        }
    }

// perfect
    void ThirdMethod(int thirdNum)
    {
        switch (thirdNum)
        {
            case 66:
                Debug.Log("this number is 66");

                // you could also do:
                // Debug.Log($"this number is {thirdNum}");
                // then, you can re-use user input. you can also do that in all other cases
                
                break;
            case 0:
                Debug.Log("this number is a big zero");
                break;
            case 100:
                Debug.Log("a hundred is a big number");
                break;
        }
    }


}
