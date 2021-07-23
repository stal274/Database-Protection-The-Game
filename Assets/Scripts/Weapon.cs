using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private string _typeOfCyberattack;
    [SerializeField] private int _damage;
    [SerializeField] private AudioSource _punchSound;

    public int Damage { get => _damage; }
    public string TypeOfCyberattack { get => _typeOfCyberattack; }

    public void ToDamage()
    {


    }

}
