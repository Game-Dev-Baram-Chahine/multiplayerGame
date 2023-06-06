using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class ScoreManager : NetworkBehaviour
{
    [SerializeField] NumberField ScoreDisplay;

    [Networked(OnChanged = nameof(ScoreChanged))]
    public int Score { get; set; } = 0;

    private static void ScoreChanged(Changed<ScoreManager> changed)
    {
        // Here you would add code to update the player's healthbar.
        Debug.Log($"Health changed to: {changed.Behaviour.Score}");
        changed.Behaviour.ScoreDisplay.SetNumber(changed.Behaviour.Score);
    }
    public void AddScore(int score)
    {
        Score += score;
    }
}
