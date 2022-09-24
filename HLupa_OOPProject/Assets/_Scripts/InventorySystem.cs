using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour, Observer
{
    private List<Collectible> inventory = new List<Collectible>();
    public void OnNotify(Collectible obj, NotificationType notificationType) 
    {
        inventory.Add(obj);
        Debug.Log("bongo bongo");
        string name = obj.GetName();
        Debug.Log(name);
    }

    void Start() 
    {
        foreach (SubjectObserved subj in FindObjectsOfType<SubjectObserved>()) 
        {
            subj.AddObserver(this);
        }
    }
}
