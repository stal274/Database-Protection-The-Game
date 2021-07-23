using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] private int _armor;
    [SerializeField] private string[] _vulnerableTo, _protectedFrom;
    [SerializeField] private Dictionary<string, double> _damageCoefficient;

    private void Start()
    {
        _damageCoefficient = new Dictionary<string, double>{
            {"Increased",1.5},
            {"Normal",1.0},
            {"Reduced",0.3}
            };
    }


    private void ReceiveDamage(Weapon weapon)
    {
        string typeOfWeapon = "Normal";
        _armor = Convert.ToInt32(_armor - weapon.Damage * _damageCoefficient[typeOfWeapon]);
    }


}
