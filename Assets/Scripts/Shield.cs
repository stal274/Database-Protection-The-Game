using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Shield : MonoBehaviour
{
    [Header("Настройка щита")]
    [SerializeField] private float _armor;
    private bool IsAlive => _armor > 0;
    public static event Action Bullethit;
    private void ReceiveDamage(Bullet bullet)
    {
        _armor -= bullet.Damage;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ReceiveDamage(other.gameObject.GetComponent<Bullet>());
        InvokingEvents();
        Destroy(other.gameObject);
    }

    private static void InvokingEvents()
    {
        TargetHit hit = new TargetHit();
        hit.Accept(new DoSomething());
        Bullethit.Invoke();
    }

    private void FixedUpdate()
    {
        if (IsAlive == false)
        {
            Destroy(gameObject);
        }
    }
}



