using UnityEngine;
using Zenject;

public sealed class MoveController : ITickable
{
    private IMoveInput _moveInput;
    private ICharacter _character;

    public MoveController(IMoveInput moveInput, ICharacter character)
    {
        _moveInput = moveInput;
        _character = character;
    }   

    void ITickable.Tick()
    {
        _character.Move(_moveInput.GetDirection(), Time.deltaTime);
    }
}
