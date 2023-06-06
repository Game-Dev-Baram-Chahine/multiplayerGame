using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] NumberField ScoreDisplay;

    public void AddScore(int score)
    {
        ScoreDisplay.SetNumber(ScoreDisplay.GetNumber() + score);
    }
}
