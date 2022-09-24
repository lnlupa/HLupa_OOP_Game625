using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface UIObserver 
{
    public void OnUINotify(List<Collectible> InventoryList, string objName);
}
