using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerVitals : MonoBehaviour
{

    public Slider Healthslider;
    public int maxHealth;
    public int healthFallrate;

    public Slider Thirstslider;
    public int maxThirst;
    public int thirstFallrate;

    public Slider Hungerslider;
    public int maxHunger;
    public int hungerFallrate;

    void Start()
    {
        Healthslider.maxValue = maxHealth;
        Healthslider.value = maxHealth;

        Thirstslider.maxValue = maxThirst;
        Thirstslider.value = maxThirst;

        Hungerslider.maxValue = maxHunger;
        Hungerslider.value = maxHunger;

    }

    void Update()
    {
        if (Hungerslider.value <= 0 && (Thirstslider.value <= 0))
        {
            Healthslider.value -= Time.deltaTime / healthFallrate * 2;
        }

        else if (Hungerslider.value <= 0 || Thirstslider.value <= 0)
        {
            Healthslider.value -= Time.deltaTime / healthFallrate;
        }
        if (Healthslider.value <= 0)
        {
            CharacterDeath();
        }
        //hunger control
        if (Hungerslider.value >= 0)
        {
            Hungerslider.value -= Time.deltaTime / hungerFallrate;
        }
        else if (Hungerslider.value >= 0)
        {
            Hungerslider.value = 0;
        }
        else if (Hungerslider.value >= maxHunger)
        {
            Hungerslider.value = maxHunger;
        }

        if (Thirstslider.value >= 0)
        {
            Thirstslider.value -= Time.deltaTime / thirstFallrate;
        }
        else if (Thirstslider.value >= 0)
        {
            Thirstslider.value = 0;
        }
        else if (Thirstslider.value >= maxThirst)
        {
            Thirstslider.value = maxThirst;
        }


    }
    void CharacterDeath()
    {
        //insert action
    }
}
