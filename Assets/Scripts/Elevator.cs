using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator
{
    // ususally for private variables there is a naming convention - underscore, so this would be: int _currentFloor = 0; this is done to diffrentiate class varibales from method variables
    int currentFloor = 0;

    public int ButtonPressed(int floorNumber)
    {
        Debug.Log($"going to floor {floorNumber}");
        return floorNumber;
    }
    public void GoUp(int howManyFloorsUp)
    {
        currentFloor += howManyFloorsUp;
        Debug.Log($"go up {howManyFloorsUp} floors");
    }

    public void GoDown(int howManyFloorsDown)
    {
        currentFloor -= howManyFloorsDown;
        Debug.Log($"go down {howManyFloorsDown} floors");
    }

    public void SabathMode(bool isSabath)
    {
        /*  
        bracets in if are nessecerray only if there is more than one line below the if, so you could do the following:
        
        if (isSabath)
            Debug.Log("stops at every floor for 3 minutes");
        */
        
        if (isSabath)
        {
            Debug.Log("stops at every floor for 3 minutes");
        }
    }

    public void CloseDoors(bool isDoorNotObstructed)
    {
        if (isDoorNotObstructed)
        {
            Debug.Log("doors closing");
        }
        else
        {
            Debug.Log("somthing is blocking the door, keeping doors open");
        }

        //you could use early exit here like the following:
        /*
            if (isDoorNotObstructed)
            {
                Debug.Log("doors closing");
                // this part will exit the function, preventing running the code below the return. this is called "Early Exit"
                return;
            }

            // this part would happen only if we didn't enter the if body, since if we did - we would return from the function and would never reach below the return statement.
            Debug.Log("somthing is blocking the door, keeping doors open");
        */
    }
}

