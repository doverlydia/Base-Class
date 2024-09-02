using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevetorOporator : MonoBehaviour
{
    void Start()
    {
        Elevator elevator = new Elevator();

        int currentFloor = 0;
        int floorNumber = 5;
        bool isSabath = false;
        bool isDoorNotObstructed = true;

        int targetFloor = elevator.ButtonPressed(floorNumber);

        // this is huge moolitic code that is better extracted into methods
        if (!isSabath && isDoorNotObstructed)
        {
            if (targetFloor > currentFloor)
            {
                elevator.CloseDoors(true);
                elevator.GoUp(targetFloor - currentFloor);
                Debug.Log($"u are on floor {currentFloor} and u pressed {targetFloor}, going up {currentFloor + floorNumber} floors");
                currentFloor = targetFloor;
                Debug.Log($"u are on floor {currentFloor}");
                // insted:
                // GoUp();
                // return; - use early exit to prevent elso if else if .....
            }
            else if (targetFloor < currentFloor)
            {
                elevator.CloseDoors(true);
                elevator.GoDown(currentFloor - targetFloor);
                currentFloor = targetFloor;
                Debug.Log($"u are on {currentFloor} and u pressed {targetFloor}, going down {currentFloor - floorNumber} floors");
                // insted:
                // GoDown();
                // return;
            }
        }
        else if (!isDoorNotObstructed)
        {
            elevator.CloseDoors(false);
            Debug.Log("something is blocking the doors");
            // return;
        }
        else
        {
            elevator.SabathMode(true);
            Debug.Log("sorry it's sabath u need to stand and stare till u reach your floor");
            // return;
        }
    }

    void GoUp()
    {
        elevator.CloseDoors(true);
        elevator.GoUp(targetFloor - currentFloor);
        currentFloor = targetFloor;
    }

    void GoDown
    {
        elevator.CloseDoors(true);
        elevator.GoDown(currentFloor - targetFloor);
        currentFloor = targetFloor;
    }
}
