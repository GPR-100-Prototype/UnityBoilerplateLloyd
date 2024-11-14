using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UIElements;

public class ProgressBar : MonoBehaviour
{
    public RectTransform Progress;
    public float progress = 0;
    public float progressScale = 0;
    public int speedValue = 2;
    private bool complete = false;

    void Start()
    {
        progress = 0;
        Progress.localScale = new Vector3(1, progressScale, 1);
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && !complete)
        {
            progress += Time.deltaTime;
            progressScale = progress / speedValue;
            Progress.localScale = new Vector3(1, progressScale, 1);
        }

        if (progressScale >= 1.0)
        {
            complete = true;
        }
    }
}
