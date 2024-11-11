using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UIElements;

public class ProgressBar : MonoBehaviour
{
    public RectTransform Progress;
    public float progress = 0;
    private bool complete = false;

    void Start()
    {
        progress = 0;
        Progress.localScale = new Vector3(1, progress, 1);
    }
    void Update()
    {
        if (Input.GetMouseButton(0) && !complete)
        {
            progress += Time.deltaTime;
            Progress.localScale = new Vector3(1, progress/10, 1);
        }

        if (progress >= 10.0)
        {
            complete = true;
        }
    }
}
