using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Singleton
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { private set; get; } 

    public UnityAction<float> OnPlayerDamage;

    private void Awake() 
    {
        Instance = this;
    }

    public void PlayerDamage(float damage)
    {
        // Notificar a todos los GO que el jugador ha recibido
        // danho
        OnPlayerDamage.Invoke(damage);
    }

    public void AddOnPlayerDamageObserver(UnityAction<float> action)
    {
        OnPlayerDamage += action;
    }
}
