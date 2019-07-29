using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsController : MonoBehaviour
{
    GridController gridController;

    [SerializeField] List<Steppable> allSteppables = new List<Steppable>();

    bool runningSteps = false;

    // Start is called before the first frame update
    void Start()
    {
        gridController = FindObjectOfType<GridController>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            runningSteps = true;
            StartCoroutine(RunSteps());
        }
    }

    IEnumerator RunSteps()
    {
        while (runningSteps)
        {
            foreach(Steppable steppable in allSteppables)
            {
                print("CallNextStep");
                steppable.CallNextStep();
                yield return new WaitForSeconds(1); 
            }
        }
    }

    public void StopRunning()
    {
        runningSteps = false;
    }
}
