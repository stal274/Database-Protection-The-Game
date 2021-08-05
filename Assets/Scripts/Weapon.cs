using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] private AudioSource _shootSound;

    private GameObject _bulletInTheBarrel;
    [SerializeField] private Magazine _magazine;
    private void OnEnable()
    {
        Shield.Bullethit += Reloading;
        Shield.Bullethit += Shoot;
    }
    private void OnDisable()
    {
        Shield.Bullethit -= Reloading;
        Shield.Bullethit -= Shoot;
    }

    public void Shoot()
    {
        if(_bulletInTheBarrel==null) return;
        Instantiate(_bulletInTheBarrel, new Vector3(424.0f, 218.561f, 0.4f), _bulletInTheBarrel.transform.rotation);
        _bulletInTheBarrel = null;
        _shootSound.Play();
    }
    public void Reloading()
    {
        _bulletInTheBarrel = _magazine.SendAPatron();
    }


}
