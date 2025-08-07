using UnityEngine;
using Zenject;

public sealed class GameController : ITickable
{
    private readonly GameManager gameManager;

    public GameController(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }
    
    void ITickable.Tick()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            gameManager.StartGame();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            gameManager.PauseGame();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            gameManager.ResumeGame();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            gameManager.FinishGame();
        }
    }
}
