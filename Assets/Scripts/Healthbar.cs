using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private Slider slider;
    // Observer

    private void Awake() 
    {
        slider = GetComponent<Slider>();
    }

    private void Start() 
    {
        // Registro como Observer
        GameManager.Instance.AddOnPlayerDamageObserver(ReduceHealth);
    }

    private void ReduceHealth(float damage)
    {
        slider.value = slider.value - damage;
    }
}
