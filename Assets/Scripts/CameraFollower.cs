using UnityEngine;
using Zenject;

public sealed class CameraFollower : ILateTickable
{
    private Camera _targetCamera;
    private ICharacter _character;
    private Vector3 _offset;

    public CameraFollower (ICharacter character, Camera camera, Vector3 offset)
    {
        _character = character;
        _targetCamera = camera;
        _offset = offset;
    }
    void ILateTickable.LateTick()
    {
        var cameraPosition = _character.GetPosition() + _offset;
        _targetCamera.transform.position = cameraPosition;
    }
}
