using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberManager : MonoBehaviour
{
    public List<bool> TasksSet;
    public VgruberKrampusEnemy krScript1;
    public VgruberKrampusSound krScript2;

    public void DisableAfterDeath()
    {
        krScript1.enabled = false;
        krScript2.enabled = false;
    }

   
}
