using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class MyIntEvent : UnityEvent<int>
{
}
public class Shield : MonoBehaviour
{
    [Header("Настройка щита")]
    [SerializeField] private float _armor;
    [SerializeField] private MyIntEvent _event;
    private float _maxArmor;
    private bool IsAlive => _armor > 0;

    public MyIntEvent Event { get => _event; private set => _event = value; }

    public static event Action Bullethit;
    private void Start()
    {
        if (Event == null)
        {
            Event = new MyIntEvent();
        }
    }
    private void OnEnable()
    {
        _maxArmor = _armor;

    }
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

    private void InvokingEvents()
    {
        TargetHit hit = new TargetHit();
        hit.Accept(new DoSomething());
        Bullethit.Invoke();
        Event.Invoke(Convert.ToInt32(Math.Round(_armor / _maxArmor * 4, 0) + 1));
    }

    private void FixedUpdate()
    {
        if (IsAlive == false)
        {
            Destroy(gameObject);
        }
    }
}



