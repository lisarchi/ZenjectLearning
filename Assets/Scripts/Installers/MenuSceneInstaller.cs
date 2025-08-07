using UnityEngine;
using UnityEngine.UI;
using Zenject;

public sealed class MenuSceneInstaller : MonoInstaller
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _exitButton;

    public override void InstallBindings()
    {
        Container
            .BindInterfacesTo<StartGameButton>()
            .AsSingle()
            .WithArguments(_startButton)
            .NonLazy();

        Container
            .BindInterfacesTo<ExitGameButton>()
            .AsSingle()
            .WithArguments(_exitButton)
            .NonLazy();
    }
}
