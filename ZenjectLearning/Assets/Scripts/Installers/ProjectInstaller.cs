using UnityEngine;
using Zenject;

[CreateAssetMenu(
    fileName = "ProjectInstaller",
    menuName = "Installer/New ProjectInstaller"
    )]

public sealed class ProjectInstaller : ScriptableObjectInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<ApplicationFinisher>()
            .AsSingle();
        Container
            .Bind<GameLauncher>()
            .AsSingle();
    }
}
