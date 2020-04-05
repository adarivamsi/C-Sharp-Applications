using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main Program
/// </summary>
public class PrintPercent : MonoBehaviour
{
    /// <summary>
    /// Main Method
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // Declare a constant named MaxScore of type int and assign it a value of 100.
        const int MaxScore = 100;

        // Declare a variable named score of type int and assign it a value between 0 and 100.
        int score = 16;

        // Declare a variable named percent of type float and store the percent calculated by dividing score by MaxScore. 
        // Remember how integer division works in C# and use type casting as appropriate.
        float percent = ((float) score / MaxScore) * 100;

        // Print the percent in the Unity Console window. The percent you print should be between 0% and 100%.
        print("Percent : " + percent + "%");
    }
}
