using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This program helps the game object to move
/// </summary>
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Get the game object moving
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(5, 5),
            ForceMode2D.Impulse);


    }
}
