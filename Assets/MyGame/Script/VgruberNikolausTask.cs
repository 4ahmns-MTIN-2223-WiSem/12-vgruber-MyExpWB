using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberNikolausTask : MonoBehaviour
{
    [SerializeField] GameObject NikoStick;
    [SerializeField] GameObject gutti;
    [SerializeField] Collision stNicolas;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource nico;

    [SerializeField] VgruberManager manager;

    private bool weaponActive = false;


    private void OnTriggerEnter(Collider other)
    {
        if (!weaponActive)
        {
            NikoStick.SetActive(true);
            nico.enabled = true;
            manager.KillTask();

        }

        if (anim.GetBool("Die"))
        {
            gutti.SetActive(true);
            manager.tasks[1] = new VgruberTask("Kill Krampus!", true);
        }
    }




}
