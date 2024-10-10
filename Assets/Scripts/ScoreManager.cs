using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int currentScore = 0;

    public void Increment()
    {
        currentScore++;
        ScoreText.text = currentScore.ToString();
    }
}
