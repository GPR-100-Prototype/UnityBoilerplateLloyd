using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBar : MonoBehaviour
{
    public RectTransform Red;
    public float deathProgress = 0;
    public float deathProgressScale = 0;
    public int speedValue = 3;

    void Start()
    {
        deathProgress = 0;
    }
    void Update()
    {
        if (deathProgress <= 10.0)
        {
            deathProgress += Time.deltaTime;
            deathProgressScale = deathProgress / speedValue;
            Red.localScale = new Vector3(1, deathProgressScale, 1);
        }
    }
}
