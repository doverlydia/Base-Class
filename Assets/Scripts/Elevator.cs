using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator
{
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
    }
}

