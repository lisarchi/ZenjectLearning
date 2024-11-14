using System;
using Zenject;

public sealed class DeathObserver : IInitializable, IDisposable
{
    private readonly ICharacter _character;
    private readonly GameManager _gameManager;

    public DeathObserver(ICharacter character, GameManager gameManager)
    {
        _character = character;
        _gameManager = gameManager;
    }
    void IInitializable.Initialize()
    {
        _character.OnDeath += OnDeath;
    }

    void IDisposable.Dispose()
    {
        _character.OnDeath -= OnDeath;
    }

    private void OnDeath()
    {
        _gameManager.FinishGame();
    }
}
