using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    float initialSpeed;
    Player player;

    private void Start()
    {
        player = GetComponent<Player>();
        initialSpeed = player.speed;
    }

    // Runs once on-enter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        OverlapTag tag = collision.GetComponent<OverlapTag>();
        if (tag != null)
        {
            if (tag.type == OverlapTag.Type.Speed_Up)
            {
                player.speed *= 2.0f;
            }

            else if (tag.type == OverlapTag.Type.Speed_Down)
            {
                player.speed /= 2.0f;
            }
        }
    }

    // Runs once on-exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.speed = initialSpeed;
    }
}
