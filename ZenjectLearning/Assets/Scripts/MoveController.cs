using UnityEngine;
using Zenject;

public class MoveController : ITickable
{
    private IMoveInput _moveInput;
    private ICharacter _character;

    public MoveController(IMoveInput moveInput, ICharacter character)
    {
        this._moveInput = moveInput;
        this._character = character;
    }   

    void ITickable.Tick()
    {
        this._character.Move(this._moveInput.GetDirection(), Time.deltaTime);
    }
}
