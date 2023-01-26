using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberNikolausTask : MonoBehaviour
{
    public GameObject NikoStick;
    [SerializeField] GameObject gutti;
    public Collision stNicolas;
    public Animator anim;
    public AudioSource nico;

    private bool weaponActive = false;

    private void OnTriggerEnter(Collider other)
     {
        Debug.Log("quest start");

        if (!weaponActive)
        {
            NikoStick.SetActive(true);
            nico.enabled = true; 
        }

      if (anim.GetBool("Die"))
        {
            gutti.SetActive(true);
        }
     }




}
