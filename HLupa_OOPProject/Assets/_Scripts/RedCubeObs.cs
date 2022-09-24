using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeObs : SubjectObserved, Collectible
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Notify(this, NotificationType.RedCubeCollected);
        }
    }

    public string GetName()
    {
        return "red_cube";
    }
}
