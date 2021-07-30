using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private AudioSource _shootSound;
    
     private Bullet _bulletInTheBarrel;
    [SerializeField] private Magazine _magazine;
    public int Damage { get => _damage; }
    public Bullet BulletInTheBarrel { private get => _bulletInTheBarrel; set => _bulletInTheBarrel = value; }

    private void Start()
    {

    }
    private void OnDestroy()
    {

    }
    public void ToDamage()
    {
        _bulletInTheBarrel = null;
        _shootSound.Play();

    }
    public void Reloading()
    {
       
        _magazine.SendAPatron(this);
    }
    public void Load(Bullet bullet)
    {
        _bulletInTheBarrel = bullet;
    }
}
