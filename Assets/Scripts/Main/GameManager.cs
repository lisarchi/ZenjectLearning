using System;
using UnityEngine;

public sealed class GameManager
{
    public event Action OnGameStarted;
    public event Action OnGamePaused;
    public event Action OnGameResumed;
    public event Action OnGameFinished;

    public GameState State { get; private set; }

    public void StartGame()
    {
        if (State != GameState.OFF)
        {
            return;
        }

        State = GameState.PLAY;
        OnGameStarted?.Invoke();
        Debug.Log("Game Started");
    }

    public void PauseGame()
    {
        if (State != GameState.PLAY)
        {
            return;
        }

        State = GameState.PAUSE;
        OnGamePaused?.Invoke();
        Debug.Log("Game Paused");
    }

    public void ResumeGame()
    {
        if (State != GameState.PAUSE)
        {
            return;
        }

        State = GameState.PLAY;
        OnGameResumed?.Invoke();
        Debug.Log("Game Resumed");
    }
    public void FinishGame()
    {
        if (State is not (GameState.PLAY or GameState.PAUSE))
        {
            return;
        }

        State = GameState.FINISH;
        OnGameFinished?.Invoke();
        //Time.timeScale = 0f;
        Debug.Log("Game Finished");
    }
}
