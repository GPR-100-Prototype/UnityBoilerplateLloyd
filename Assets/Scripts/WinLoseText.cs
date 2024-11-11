using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinLoseText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currentScore = 0;
    void Update()
    {
        FindObjectOfType<ProgressBar>().progress = this.currentScore;
        text.text = this.currentScore.ToString();
    }
}
