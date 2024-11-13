using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveInput : MonoBehaviour, IMoveInput
{
    public Vector3 GetDirection()
    {
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            direction.z = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        { 
            direction.z = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction.x = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction.x = 1;
        }
        return direction;
    }
}
