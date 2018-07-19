﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{

    private EndGameMenu endMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            player.GetComponent<PlayerController>().enabled = false;
            player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            player.GetComponent<Rigidbody2D>().angularVelocity = 0f;


            EndGameMenu endMenu = GameObject.FindGameObjectWithTag("GameEndMenu").GetComponent<EndGameMenu>();

            Session oppSession = GameManager.instance.sessionManager.getOpponentSession();
            Session currSession = GameManager.instance.sessionManager.getCurrentSession();

            if (oppSession == null)
                endMenu.show(Result.COMPLETED, GameManager.instance.sessionManager.getCurrentSession().elapsedTime);
            else
            {
                if (currSession.elapsedTime > oppSession.elapsedTime)
                {
                    endMenu.show(Result.DEFEAT, GameManager.instance.sessionManager.getCurrentSession().elapsedTime);
                }
                else
                {
                    endMenu.show(Result.VICTORY, GameManager.instance.sessionManager.getCurrentSession().elapsedTime);
                }
            }

        }
    }

}