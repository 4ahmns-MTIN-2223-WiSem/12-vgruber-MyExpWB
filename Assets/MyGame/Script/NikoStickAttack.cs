using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class NikoStickAttack : MonoBehaviour
{
    private bool stickAttack;
    public Animator animStick;
    

    // Start is called before the first frame update
    void Start()
    {
        stickAttack = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            PlayerAttack();
        }
    }

    public void PlayerAttack()
    {
        Debug.Log("hit");
        animStick.SetBool("isAttacking", true);
    }

}    
