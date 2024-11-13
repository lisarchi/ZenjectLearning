using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public sealed class PlayerInstaller : MonoInstaller
{
    [SerializeField] private Character _character;
    [SerializeField] private InputMap _inputMap;
    [SerializeField] private Vector3 _cameraOffset = new(0, 6, -10);
    public override void InstallBindings()
    {
        Container
            .Bind<ICharacter>()
            .To<Character>()
            .FromInstance(_character)
            .AsSingle();
        Container
            .Bind<InputMap>()
            .FromInstance(_inputMap)
            .AsSingle();

        Container
            .Bind<Camera>()
            .FromComponentInHierarchy()
            .AsSingle();

        Container
            .BindInterfacesAndSelfTo<CameraFollower>()
            .AsCached()
            .WithArguments(_cameraOffset);

        Container
            .Bind<IMoveInput>()
            .To<MoveInput>()
            .AsSingle();

        Container
            .BindInterfacesTo<DeathObserver>()
            .AsCached();

        Container
            .BindInterfacesAndSelfTo<MoveController>()
            .AsCached();
    }
}
