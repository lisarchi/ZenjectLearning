using UnityEngine;
using Zenject;

public sealed class SceneInstaller : MonoInstaller
{
    [SerializeField]
    private Character _characterPrefab;

    public override void InstallBindings()
    {
        this.Container
            .Bind<ICharacter>()
            .To<Character>()
            .FromComponentInNewPrefab(this._characterPrefab)
            .AsSingle();

        this.Container
            .Bind<Camera>()
            .FromComponentInHierarchy()
            .AsSingle();

        this.Container
            .Bind<IMoveInput>()
            .To<MoveInput>()
            .FromComponentInHierarchy()
            .AsSingle();
    }
}
