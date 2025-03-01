using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("power_up")) // check if it hits the floor or battery
        {
            Destroy(gameObject); // Destroy the bomb
        }

        if (collision.gameObject.CompareTag("power_up"))
        {
            Destroy(collision.gameObject); //destroy the battery
        }
    }
}
