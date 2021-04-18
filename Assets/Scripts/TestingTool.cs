using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="TestingTool",menuName ="Create TestingTool")]
public class TestingTool : ScriptableObject
{
    public GameState gameState;


    public void RaiseGameStateChangeEvent()
    {
        GameManager.GetInstance().FireGameStateChangeEvent(gameState);
    }
}
