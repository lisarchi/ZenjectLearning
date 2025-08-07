using System;
using Zenject;
using UnityEngine.UI;

public sealed class StartGameButton : IInitializable, IDisposable
{
    private readonly Button _button;
    private readonly GameLauncher _launcher;

    public StartGameButton(Button button, GameLauncher launcher)
    {
        _button = button;
        _launcher = launcher;
    }
    
    void IInitializable.Initialize()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }
    void IDisposable.Dispose()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        _launcher.StartGame();
    }
}
