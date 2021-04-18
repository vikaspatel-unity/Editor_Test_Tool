using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStateUI : MonoBehaviour
{
    public TMP_Text gameStateText;

    /// <summary>
    /// Subscribe GameStateChange Event.
    /// </summary>
    private void OnEnable()
    {
        GameManager.OnGameStateChangeEvent += UpdateText;
    }

    /// <summary>
    /// UnSubscribe GameStateChange Event.
    /// </summary>
    private void OnDisable()
    {
        GameManager.OnGameStateChangeEvent += UpdateText;
    }

    /// <summary>
    /// This method will always call when GameStateChange Event will be fire.
    /// This method will update text you can write your own logic to test.
    /// </summary>
    /// <param name="gameState"></param>
    private void UpdateText(GameState gameState)
    {
        gameStateText.text = gameState.ToString();
    }
}
