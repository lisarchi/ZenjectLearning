using System;
using Zenject;
using UnityEngine.UI;

public sealed class ExitGameButton : IInitializable, IDisposable
{
    private readonly Button _button;
    private readonly ApplicationFinisher _applicationFinisher;

    public ExitGameButton(Button button, ApplicationFinisher applicationFinisher)
    {
        _button = button;
        _applicationFinisher = applicationFinisher;
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
        _applicationFinisher.Finish();
    }
}
