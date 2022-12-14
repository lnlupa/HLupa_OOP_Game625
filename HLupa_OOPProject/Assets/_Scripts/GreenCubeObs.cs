using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubeObs : SubjectObserved, Collectible
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Notify(this, NotificationType.GreenCubeCollected);
        }
    }

    public string GetName() 
    {
        return "green_cube";
    }

    private void Update()
    {
        DropItem();
    }

    public void DropItem() 
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Notify(this, NotificationType.GreenCubeDropped);
        }
    }
}
