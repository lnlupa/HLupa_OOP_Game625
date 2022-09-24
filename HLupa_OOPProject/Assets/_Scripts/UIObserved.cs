using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObserved : MonoBehaviour
{
    private List<UIObserver> uiobservers = new List<UIObserver>();

    public void AddUIObserver(UIObserver observer)
    {
        uiobservers.Add(observer);
    }

    public void RemoveUIObserver(UIObserver observer)
    {
        uiobservers.Remove(observer);
    }

    public void UINotify(List<Collectible> list, string objName)
    {
        foreach (UIObserver obs in uiobservers)
        {
            obs.OnUINotify(list, objName);
        }
    }
}
