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
        this.currentScore = (int)(FindObjectOfType<ProgressBar>().progressScale * 100);
        text.text = this.currentScore.ToString();
    }
}
