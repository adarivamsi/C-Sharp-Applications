using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class helps the game object to jump when left mouse button is pressed
/// </summary>
public class Jumper : MonoBehaviour
{
    [SerializeField]
    GameObject prefabObject0;
    [SerializeField]
    GameObject prefabObject1;
    [SerializeField]
    GameObject prefabObject2;

    // Need for location of new object
    GameObject currentObject;
    
    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        currentObject = Instantiate<GameObject>(
            prefabObject0, Vector3.zero,
            Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // Change object on left mouse button pressed
        if (Input.GetMouseButton(0))
        {
            // Save current position and destroy current character
            Vector3 position = currentObject.transform.position;
            Destroy(currentObject);

            // Instantiate a new random number
            int prefabNumber = Random.Range(0,4);
            if (prefabNumber == 0)
            {
                currentObject = Instantiate(prefabObject0,
                    position, Quaternion.identity);
            }
            else if (prefabNumber == 1)
            {
                currentObject = Instantiate(prefabObject1,
                    position, Quaternion.identity);
            }
            else if (prefabNumber == 2)
            {
                currentObject = Instantiate(prefabObject2,
                    position, Quaternion.identity);
            }
            else
            {
                currentObject = Instantiate(prefabObject0,
                   position, Quaternion.identity);
            }
        }
        
    }
}
