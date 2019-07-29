using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steppable : MonoBehaviour
{
    public void CallNextStep()
    {
        SendMessage("ExecuteNextStep");
    }
}
