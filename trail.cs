using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTrail : MonoBehaviour
{
    // Trail
    private TrailRenderer Trail;

    // Speed & Properties
    public float MoveSpeed = 2.85f;

    // Time 
    private float Duration = 0;
    public float OperatingDuration = 4;

    // Booleans
    private bool IsDirectionPositive = true;

    private void Update()
    {
        if (IsDirectionPositive)
        {
            if(Duration < OperatingDuration)
            {
                Duration += Time.deltaTime;
                transform.Translate(transform.TransformDirection(transform.up) * MoveSpeed * Time.deltaTime);
            }
            else
            {
                Duration = 0;
                IsDirectionPositive = false;
            }
        }
        else
        {
            if (Duration < OperatingDuration)
            {
                Duration += Time.deltaTime;
                transform.Translate(transform.TransformDirection(-transform.up) * MoveSpeed * Time.deltaTime);
            }
            else
            {
                Duration = 0;
                IsDirectionPositive = true;
            }
        }
    }
}
