using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUIHandler : MonoBehaviour, UIObserver
{
    TMP_Text UIText;
    int GreenCount;
    int RedCount;
    int OrangeCount;
    AudioSource _pickupSound;

    // Start is called before the first frame update
    void Start()
    {
        UIText = GetComponentInChildren<TMP_Text>();
        _pickupSound = GetComponent<AudioSource>();
        if(_pickupSound == null) 
        {
            Debug.LogError("the sound is null!!");
        }

        foreach (UIObserved subj in FindObjectsOfType<UIObserved>())
        {
            subj.AddUIObserver(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    public void OnUINotify(List<Collectible> InventoryList, string objName) 
    {
        int count = InventoryList.Count;

        if (objName == "green_cube") 
        {
            GreenCount = count;
            _pickupSound.Play();
        }
        if (objName == "red_cube")
        {
            RedCount = count;
            _pickupSound.Play();
        }
        if (objName == "orange_cube")
        {
            OrangeCount = count;
            _pickupSound.Play();
        }
    }

    public void UpdateUI() 
    {
        UIText.SetText("Green Cubes: " + GreenCount + "\n" + "Red Cubes: " + RedCount + "\n" + "Orange Cubes: " + OrangeCount);
    }
}
