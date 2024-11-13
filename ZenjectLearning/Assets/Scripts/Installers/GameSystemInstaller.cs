using UnityEngine;
using Zenject;

[CreateAssetMenu(
    fileName = "GameSystemInstaller", 
    menuName = "Installers/New GameSystemInstaller"
)]

public sealed class GameSystemInstaller : ScriptableObjectInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<GameManager>()
            .AsSingle();
    }
}
