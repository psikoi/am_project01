using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    /* O player ao qual este script está associado */
    private Player localPlayer;

    /* Animator */
    private Animator anim;

    private void Start()
    {
        localPlayer = gameObject.GetComponent<Player>();
        anim = GetComponent<Animator>();
        Character character = GameManager.instance.characterChoosen;
        if (character.name == "Buster")
        {
            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Buster");
        }
        else if (character.name == "Sargent")
        {
            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Sargent"); 
        }
        else
        {
            anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Scout");
        }
    }

	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(localPlayer.movement.body.velocity.x));
        anim.SetBool("Grounded", localPlayer.movement.grounded);
    }
}
