using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    Animator animator;
    private string currentState;

    //Animations states
    const string PLAYER_IDLE = "Player_idle";
    const string PLAYER_RUNNING = "Player_running";
    const string PLAYER_WALKING = "Player_walking";
    const string PLAYER_DYING = "Player_dying";
    const string PLAYER_CHOPPINGWOOD = "Player_choppingwood";
    const string PLAYER_PICKINGUP = "Player_pickingup";


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void ChangeAnimationState(string newState)
    {
        //stop the same animation from interrupting itself
        if (currentState == newState) return;

        //Play de animation
        animator.Play(newState);

        //reassing the current state
        currentState = newState;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeAnimationState(PLAYER_WALKING);
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeAnimationState(PLAYER_RUNNING);
        }else if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeAnimationState(PLAYER_DYING);
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeAnimationState(PLAYER_CHOPPINGWOOD);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            ChangeAnimationState(PLAYER_PICKINGUP);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            ChangeAnimationState(PLAYER_IDLE);
        }



    }

}
