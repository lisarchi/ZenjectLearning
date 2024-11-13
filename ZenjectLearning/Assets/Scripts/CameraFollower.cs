using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public sealed class CameraFollower : MonoBehaviour
{
    private Camera _targetCamera;
    private ICharacter _character;
    [SerializeField] private Vector3 _offset;


    [Inject]
    public void Construct(ICharacter character, Camera camera)
    {
        this._character = character;
        this._targetCamera = camera;
    }
    private void LateUpdate()
    {
        var cameraPosition = this._character.GetPosition() + this._offset;
        this._targetCamera.transform.position = cameraPosition;
    }
}
