using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinLoseText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public int currentScore = 0;
    public double redBar = 0;
    public double greenBar = 0;
    public bool stopRed = false;
    public bool stopGreen = false;
    void Update()
    {
        this.redBar = FindObjectOfType<RedBar>().deathProgressScale;
        this.greenBar = FindObjectOfType<ProgressBar>().progressScale;
        
        this.currentScore = (int)(FindObjectOfType<ProgressBar>().progressScale * 100);
        text.text = this.currentScore.ToString();

        if (this.redBar >= 1 && this.redBar > this.greenBar)
        {
            text.text = "LOSE";
            stopGreen = true;
        }
        else if (this.greenBar >= 1 && this.greenBar > this.redBar)
        {
            text.text = "WIN";
            stopRed = true;
        }
    }
}
