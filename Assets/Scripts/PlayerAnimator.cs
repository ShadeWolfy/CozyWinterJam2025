using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private PlayerManager player;
    private SpriteRenderer sprite;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<PlayerManager>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (player.moveDir.x != 0) {
            animator.SetBool("Move", true);
            
            SpriteDirectionChecker();
        }
        else if (player.moveDir.y != 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (player.moveDir.x < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
    }
}
