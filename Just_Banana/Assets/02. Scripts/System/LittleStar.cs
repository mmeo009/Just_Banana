using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LittleStar : MonoBehaviour
{
    public Light lightSource_1;
    public Light lightSource_2;
    public float minIntensity = 20.0f;
    public float maxIntensity = 100.0f;
    public float speed = 10f;
    private float intensity_1;
    private float intensity_2;

    void Start()
    {
        // Initialize the target intensity to the current intensity of the light source
        intensity_1 = lightSource_1.intensity;
    }

    void Update()
    {
        // Update the target intensity based on the sine of the current time and speed
        intensity_1 = Mathf.Lerp(minIntensity, maxIntensity, Mathf.Sin(Time.time * speed));
        intensity_2 = Mathf.Lerp(maxIntensity, minIntensity, Mathf.Sin(Time.time * speed));
        // Smoothly adjust the light intensity towards the target intensity
        lightSource_1.intensity = Mathf.Lerp(lightSource_1.intensity, intensity_1, Time.deltaTime);
        lightSource_2.intensity = Mathf.Lerp(lightSource_2.intensity, intensity_2, Time.deltaTime);
    }
}
