using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UIElements;

public class ProgressBar : MonoBehaviour
{
    public RectTransform Progress;
    public float progress = 0;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            progress += Time.deltaTime;
            Progress.localScale = new Vector3(1, progress/10, 1);
        }
    }
}
