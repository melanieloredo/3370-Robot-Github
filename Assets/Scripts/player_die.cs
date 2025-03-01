using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_dead : MonoBehaviour
{
    //deleted methods start & update bcus we dont want it once nor per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bomb_enemy"))
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.CompareTag("power_up"))
        {
            Destroy(collision.gameObject); //destroy the battery
            score_manager.instance.addPoints();
        }
    }
}
