using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCubeObs : SubjectObserved, Collectible
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Notify(this, NotificationType.OrangeCubeCollected);
        }
    }

    public string GetName()
    {
        return "orange_cube";
    }

    private void Update()
    {
        DropItem();
    }

    public void DropItem()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Notify(this, NotificationType.OrangeCubeDropped);
        }
    }
}
