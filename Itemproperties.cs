using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Itemproperties : MonoBehaviour
{
    [Header("Your Consumables")]
    public string itemName;

    [SerializeField] private bool food;
    [SerializeField] private bool water;
    [SerializeField] private bool health;
    [SerializeField] private float value;

    [SerializeField] private PlayerVitals playervitals;

    public void Interaction()
    {
        if (food)
        {
            playervitals.Hungerslider.value += value;
        }
        else if (water)
        {
            playervitals.Thirstslider.value += value;
        }
        else if (health)
        {
            playervitals.Healthslider.value += value;
        }
    }

}
