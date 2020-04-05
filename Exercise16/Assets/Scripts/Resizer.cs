using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used for resizing game object
/// </summary>
public class Resizer : MonoBehaviour
{
    // Fields declared for Time Support
    const float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    // Fields declared for Resining control
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;

    // Update is called once per frame
    void Update()
    {
        // To resize game object
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;

        // update timer and check if it's done
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {

            // reset timer and start resizing the game object
            // in the opposite direction
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
