using UnityEngine;

public sealed class MoveInput : IMoveInput
{
    private readonly InputMap _inputMap;
    public MoveInput(InputMap inputMap)
    {
        _inputMap = inputMap;
    }
    public Vector3 GetDirection()
    {
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(_inputMap.forward))
        {
            direction.z = 1;
        }
        else if (Input.GetKey(_inputMap.back))
        { 
            direction.z = -1;
        }
        if (Input.GetKey(_inputMap.left))
        {
            direction.x = -1;
        }
        else if (Input.GetKey(_inputMap.right))
        {
            direction.x = 1;
        }
        return direction;
    }
}
