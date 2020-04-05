using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A Rock
/// </summary>
public class Rock : MonoBehaviour
{
    [SerializeField]
    Sprite sprite0;

    [SerializeField]
    Sprite sprite1;

    [SerializeField]
    Sprite sprite2;

    /// <summary>
    /// Use this for intilization
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // Apply impulse force to get rock moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;

        int spriteValue = Random.Range(0, 3);

        if (spriteValue == 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite0;
        }
        else if (spriteValue == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else if (spriteValue == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = sprite0;
        }

        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}