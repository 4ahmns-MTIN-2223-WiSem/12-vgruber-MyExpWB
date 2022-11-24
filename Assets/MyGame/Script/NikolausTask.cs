using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikolausTask : MonoBehaviour
{
    public GameObject NikoStick;
    public Collision stNicolas;

    private void OnTriggerEnter(Collider other)
     {
        Debug.Log("quest start");
        NikoStick.SetActive(true);
     }




}
