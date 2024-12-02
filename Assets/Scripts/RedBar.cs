using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBar : MonoBehaviour
{
    public RectTransform Red;
    public float deathProgress = 0;
    public float deathProgressScale = 0;
    public int speedValue = 5;
    private bool allowedProgress = false;
    
    IEnumerator Start()
    {
        deathProgress = 0;
        yield return new WaitForSeconds(2);
        allowedProgress = true;
    }
    void Update()
    {
        if (deathProgressScale <= 1 && allowedProgress)
        {
            deathProgress += Time.deltaTime;
            deathProgressScale = deathProgress / speedValue;
            Red.localScale = new Vector3(1, deathProgressScale, 1);
        }
    }
}
