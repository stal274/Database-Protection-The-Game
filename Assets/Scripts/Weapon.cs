using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private AudioSource _punchSound;
    [SerializeField] private Rigidbody2D _bullet;

    public int Damage { get => _damage; }
   
    public void ToDamage()
    {


    }
}
