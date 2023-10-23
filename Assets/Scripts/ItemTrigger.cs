using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ItemTrigger : MonoBehaviour
{
    float initialSpeed;
    Player player;
    public int score = 0;
    public int lives = 3;

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
                player.speed *= 3.0f;
                score += 1;
                Debug.Log("Score =" + score);
            }

            else if (tag.type == OverlapTag.Type.Speed_Down)
            {
                player.speed /= 3.0f;
                score -= 1;
                lives -= 1;
                Debug.Log("Score = " + score);
                if (lives <= 0)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
        
    }

    // Runs once on-exit
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.speed = initialSpeed;
    }
}
