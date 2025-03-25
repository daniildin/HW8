using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScale : MonoBehaviour
{
    public float scaleFactor = 1f; // Scaling speed per second
    public float duration = 2f; // Time before reversing direction
    private float timer = 0f;
    private int scaleSign = 1; // Controls the scaling direction

    void Update()
    {
        // Update the timer
        timer += Time.deltaTime;

        // Change scale gradually over time
        transform.localScale += Vector3.one * scaleFactor * scaleSign * Time.deltaTime;

        // Reverse the scaling direction after duration time has passed
        if (timer >= duration)
        {
            scaleSign *= -1; // Reverse scaling direction
            timer = 0f; // Reset the timer
        }
    }
}