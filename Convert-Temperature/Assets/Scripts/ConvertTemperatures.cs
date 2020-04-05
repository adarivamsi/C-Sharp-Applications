using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{
    /// <summary>
    /// Main Class
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // Declare three int variables to store an original temperature in Fahrenheit, a calculated temperature in Celsius, 
        //and a calculated temperature in Fahrenheit (when you convert from Celsius back to Fahrenheit).   
        int orgFahr;
        int calCel;
        int calFahr;

        // Declare three float variables to store an original temperature in Fahrenheit, a calculated temperature 
        // in Celsius, and a calculated temperature in Fahrenheit (when you convert from Celsius back to Fahrenheit).
        float orgFahr1;
        float calCel1;
        float calFahr1;

        // Declare three double variables to store an original temperature in Fahrenheit, a calculated temperature in 
        // Celsius, and a calculated temperature in Fahrenheit(when you convert from Celsius back to Fahrenheit).
        double orgFahr2;
        double calCel2;
        double calFahr2;

        // Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print 
        // the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label 
        // each of your outputs rather than just printing out the numbers.
        orgFahr = 0;
        print("Original Temperature in Fahrenheit : " + orgFahr);

        calCel = ((orgFahr - 32) / 9 )* 5;
        print("Converted Temperature in Celsius : " + calCel);

        calFahr = ((calCel * 9) / 5) + 32;
        print("Converted Temperature in Fahrenheit : " + calFahr);

        // Assign 32 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print 
        // the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label 
        // each of your outputs rather than just printing out the numbers.
        orgFahr = 32;
        print("Original Temperature in Fahrenheit : " + orgFahr);

        calCel = ((orgFahr - 32) / 9) * 5;
        print("Converted Temperature in Celsius : " + calCel);

        calFahr = ((calCel * 9) / 5) + 32;
        print("Converted Temperature in Fahrenheit : " + calFahr);

        // Assign 212 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print the 
        // Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label each 
        // of your outputs rather than just printing out the numbers.
        orgFahr = 212;
        print("Original Temperature in Fahrenheit : " + orgFahr);

        calCel = ((orgFahr - 32) / 9) * 5;
        print("Converted Temperature in Celsius : " + calCel);

        calFahr = ((calCel * 9) / 5) + 32;
        print("Converted Temperature in Fahrenheit : " + calFahr);

        // Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print 
        // the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label 
        // each of your outputs rather than just printing out the numbers.
        orgFahr1 = 0;
        print("Float Original Temperature in Fahrenheit : " + orgFahr1);

        calCel1 = ((orgFahr1 - 32) / 9) * 5;
        print("Float Converted Temperature in Celsius : " + calCel1);

        calFahr1 = ((calCel1 * 9) / 5) + 32;
        print("Float Converted Temperature in Fahrenheit : " + calFahr1);

        // Assign 0 as your original temperature in Fahrenheit and print that Fahrenheit value, convert to Celsius and print 
        // the Celsius value, then convert the Celsius value back to Fahrenheit and print the Fahrenheit value. Be sure to label 
        // each of your outputs rather than just printing out the numbers.
        orgFahr2 = 0;
        print("Double Original Temperature in Fahrenheit : " + orgFahr2);

        calCel2 = ((orgFahr2 - 32) / 9) * 5;
        print("Double Converted Temperature in Celsius : " + calCel2);

        calFahr2 = ((calCel2 * 9) / 5) + 32;
        print("Double Converted Temperature in Fahrenheit : " + calFahr2);

    }
}
