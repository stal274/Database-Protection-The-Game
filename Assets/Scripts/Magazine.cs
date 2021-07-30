using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{

    [SerializeField] private Bullet[] _bullets;
    private int _bulletsCount;
    private void Start()
    {
        _bulletsCount = _bullets.Length;
    }
    public void SendAPatron( Weapon weapon)
    {
        Bullet bulletToLoad = _bullets[_bulletsCount];
        if (bulletToLoad == null) return;
        weapon.Load(bulletToLoad);
        _bulletsCount -= 1;
    }

}
