using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Enums for handling game state.
/// </summary>
public enum GameState
{
    StateMenu,
    StateGamePlay,
    StateGamePause,
    StateGameOver
}

public class GameManager : MonoBehaviour
{

    private static GameManager _instance;
    public delegate void GameStateChangeDelegate(GameState gameState);
    public static event GameStateChangeDelegate OnGameStateChangeEvent;
    public GameState currentGameState;

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
    }

    public static GameManager GetInstance()
    {
        return _instance;
    }


    public void FireGameStateChangeEvent(GameState gameState)
    {
        currentGameState = gameState;
        OnGameStateChangeEvent?.Invoke(gameState);
    }
}
