using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : UIObserved, Observer
{
    private List<Collectible> inventoryGreen = new List<Collectible>();
    private List<Collectible> inventoryRed = new List<Collectible>();
    private List<Collectible> inventoryOrange = new List<Collectible>();
    public void OnNotify(Collectible obj, NotificationType notificationType) 
    {
        if(notificationType == NotificationType.GreenCubeCollected)
        {
            inventoryGreen.Add(obj);
            string name = obj.GetName();
            Debug.Log(name);
            //Debug.Log(inventoryGreen.Count);
            UINotify(inventoryGreen, name);
        }

        if (notificationType == NotificationType.GreenCubeDropped) 
        {
            if (inventoryGreen.Count <= 0)
            {
                print("green inventory empty!");
            }
            else 
            {
                inventoryGreen.Remove(obj);
                string name = obj.GetName();
                Debug.Log(name + " removed");
                //Debug.Log(inventoryGreen.Count);
                UINotify(inventoryGreen, name);
            }
        }

        if(notificationType == NotificationType.OrangeCubeCollected)
        {
            inventoryOrange.Add(obj);
            string name = obj.GetName();
            Debug.Log(name);
            //Debug.Log(inventoryOrange.Count);
            UINotify(inventoryOrange, name);
        }


        if (notificationType == NotificationType.OrangeCubeDropped)
        {
            if (inventoryOrange.Count <= 0)
            {
                print("orange inventory empty!");
            }
            else 
            {
                inventoryOrange.Remove(obj);
                string name = obj.GetName();
                Debug.Log(name + " removed");
                //Debug.Log(inventoryOrange.Count);
                UINotify(inventoryOrange, name);
            }
        }

        if (notificationType == NotificationType.RedCubeCollected)
        {
            inventoryRed.Add(obj);
            string name = obj.GetName();
            Debug.Log(name);
            //Debug.Log(inventoryRed.Count);
            UINotify(inventoryRed, name);
        }

        if (notificationType == NotificationType.RedCubeDropped)
        {
            if (inventoryRed.Count <= 0)
            {
                print("red inventory empty");
            }
            else 
            {
                inventoryRed.Remove(obj);
                string name = obj.GetName();
                Debug.Log(name + " removed");
                //Debug.Log(inventoryRed.Count);
                UINotify(inventoryRed, name);
            }
        }
    }

    void Start() 
    {
        foreach (SubjectObserved subj in FindObjectsOfType<SubjectObserved>()) 
        {
            subj.AddObserver(this);
        }
    }
}
