using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage = 10f;

    private void Start() 
    {
        GameManager.Instance.AddOnPlayerDamageObserver(PlayerDamage);   
    }

    private void PlayerDamage(float damage)
    {
        Debug.Log("El enemigo reacciono a danho del jugador");
    }
}
