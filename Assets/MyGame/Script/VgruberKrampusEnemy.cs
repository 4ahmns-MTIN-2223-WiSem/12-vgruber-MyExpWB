using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KState
{
    Idle,
    Following,
    Attack,
    Dead
}

public class VgruberKrampusEnemy : MonoBehaviour
{
    private KState AKState;
    [SerializeField] Collider colliderW;
    [SerializeField] Material material;
    [SerializeField] Animator krampusA;

    [SerializeField] VgruberKrampusSound soundManager;
    [SerializeField] VgruberManager manager;

    [SerializeField] float healthK = 150f;

    // Start is called before the first frame update
    void Start()
    {
        AKState = KState.Idle;
        StateSwitched(AKState);
        krampusA.SetBool("Die", false);
        krampusA.SetBool("Damage", false);
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.impulse); //Future ME: ? Add Min Impulse for Hit

        if (collision.collider == colliderW)
        {
            healthK = healthK - RandomDamage();

            soundManager.HitSound();

            krampusA.SetBool("Damage", true);
            AKState = KState.Attack;
            StateSwitched(AKState);

            DeathCheck();
        }
    }

    private void StateSwitched(KState state)
    {
        switch (state)
        {
            case KState.Idle:
                material.color = Color.white;
                break;

            case KState.Attack:
                material.color = Color.red;
                break;

            case KState.Following:
                break;
            case KState.Dead:
                material.color = Color.black;
                break;
        }
    }

    private float RandomDamage()
    {
        float x;
        x = Random.Range(20, 75);

        return x;
    }

    private void DeathCheck()
    {
        if (healthK <= 0)
        {
            Debug.Log("dead");
            krampusA.SetBool("Die", true);

            soundManager.DeathSound();  //sound managemet
            soundManager.hasDied = true;


            AKState = KState.Dead;      //state management
            StateSwitched(AKState);

            healthK = 0;

            manager.DisableAfterDeath();
        }
    }
}
