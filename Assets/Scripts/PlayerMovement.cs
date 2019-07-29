using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    List<TileFloor> Steps = new List<TileFloor>();
    int nextFloorStepIndex = 0;
    StepsController stepsController;

    // Start is called before the first frame update
    void Start()
    {
        stepsController = FindObjectOfType<StepsController>();
    }

    public void AddStep(TileFloor tileFloor)
    {
        Steps.Add(tileFloor);
        print("New step: Move to " + tileFloor.name);
    }

    public void ExecuteNextStep()
    {
        print("Start Coroutine");
        StartCoroutine(NextStepCoroutine());
    }

    IEnumerator NextStepCoroutine()
    {
        print("Next Step Coroutine to: " + Steps[nextFloorStepIndex].name);

        transform.position = Steps[nextFloorStepIndex].transform.position;
        nextFloorStepIndex++;
        if (nextFloorStepIndex >= Steps.Count)
        {
            stepsController.StopRunning();
        }
        yield return new WaitForSeconds(1);
    }
}
