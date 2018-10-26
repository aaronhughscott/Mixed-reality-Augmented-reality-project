
using System;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule.Tests
{
    /// <summary>
    /// This class implements IInputClickHandler to handle the tap gesture.
    /// It increases the scale of the object when tapped.
    /// </summary>
    public class AARONSTapResponder : MonoBehaviour, IInputClickHandler
    {
        [Header("Your Consumables")]
        public string itemName;

        [SerializeField] private bool food;
        [SerializeField] private bool water;
        [SerializeField] private bool health;
        [SerializeField] private float value;

        [SerializeField] private PlayerVitals playervitals;
        public void OnInputClicked(InputClickedEventData eventData)
        {
            // Increase the scale of the object just as a response.
          
            {
                if (food)
                {
                    playervitals.Hungerslider.value += value;
                    gameObject.SetActive(false);
                }
                else if (water)
                {
                    playervitals.Thirstslider.value += value;
                    gameObject.SetActive(false);
                }
                else if (health)
                {
                    playervitals.Healthslider.value += value;
                    gameObject.SetActive(false);
                }
            }

        } 
    }
    }
