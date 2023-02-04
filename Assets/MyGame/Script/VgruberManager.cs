using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberManager : MonoBehaviour
{
    public VgruberKrampusEnemy krScript1;
    public VgruberKrampusSound krScript2;
    public List<VgruberTask> tasks;

    private void Start()
    {
        tasks.Add(new VgruberTask("Talk to St. Nikolaus", false));
    }

    public void KillTask()
    {
        tasks[0] = new VgruberTask("Talk to St. Nikolaus", true);
        tasks.Add(new VgruberTask("Kill Krampus!", false));
    }


    public void DisableAfterDeath()
    {
        krScript1.enabled = false;
        krScript2.enabled = false;
    }


}
