using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Observer
{
    void OnNotify(Collectible obj, NotificationType notificationType);
}

public enum NotificationType 
{
    GreenCubeCollected,
    RedCubeCollected,
    OrangeCubeCollected,
    GreenCubeDropped,
    RedCubeDropped,
    OrangeCubeDropped
} 