using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [Header("Настройка щита")]
    [SerializeField]
    private int _armor;
    [SerializeField]
    private double _increasedCoefficient;
    [SerializeField]
    private Weapon[] _vulnerableTo;
    [SerializeField]
    private double _reducedCoefficient;
    [SerializeField]
    private Weapon[] _protectedFrom;
    

    private readonly Dictionary<Weapon, double> _damageCoefficient = new Dictionary<Weapon, double>();

    private void Start()
    {
        foreach (Weapon w in _vulnerableTo)
        {
            _damageCoefficient[w] = _increasedCoefficient;
        }
        foreach (Weapon w in _protectedFrom)
        {
            _damageCoefficient[w] = _reducedCoefficient;
        }
    }


    private void ReceiveDamage(Weapon weapon)
    {
        _armor = Convert.ToInt32(_armor - weapon.Damage * _damageCoefficient[weapon]);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}


