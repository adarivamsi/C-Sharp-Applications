using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Jump support location
    const float minX = 5;
    const float maxX = 8.9f;
    const float minY = 2;
    const float maxY = 5;
    

    // Timer support
    const float TotalJumpDelaySeconds = 1;
    float elapsedJumpDelaySeconds = 0;

    void Update()
    {
        // Update timer and Check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if(elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3(
                Random.Range(minX,minY),
                Random.Range(maxX,maxY),
                0);
        }
    }
}
