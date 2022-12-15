using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum KState{
    Idle,
    Following,
    Attack
}

public class KrampusEnemy : MonoBehaviour
{
    public KState AKState;
    public Collider colliderW;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        AKState = KState.Idle;
        StateSwitched(AKState);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == colliderW)
        {
            Debug.Log("Krampus hit!");
            AKState = KState.Attack;
            StateSwitched(AKState);
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
        }
    }
}
