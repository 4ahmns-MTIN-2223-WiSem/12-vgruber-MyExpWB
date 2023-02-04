using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VgruberTask : MonoBehaviour
{
    public bool status;
    public string nameT;

    public VgruberTask(string newName, bool newStat)
    {
        status = newStat;
        nameT = newName;

    }
}
