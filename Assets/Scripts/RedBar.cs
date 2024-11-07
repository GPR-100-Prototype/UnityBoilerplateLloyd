using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBar : MonoBehaviour
{
    public RectTransform Red;
    public float deathProgress = 0;
    void Update()
    {
        deathProgress += Time.deltaTime;
        Red.localScale = new Vector3(1, deathProgress/25, 1);
    }
}
