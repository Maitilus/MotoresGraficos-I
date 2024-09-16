using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public PlayerScore Score;

    void Start()
    {
        ScoreText.text = $"Score: {Score.CurrentScore}/{Score.TotalCoins.Length}";
    }

    void Update()
    {
        ScoreText.text = $"Score: {Score.CurrentScore}/{Score.TotalCoins.Length}";
    }
}
    