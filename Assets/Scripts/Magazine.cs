using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Magazine : MonoBehaviour
{

    [SerializeField] private GameObject[] _bullets;
    [SerializeField] private int _bulletsCount;
    public GameObject SendAPatron()
    {
        GameObject bulletOnTop;
        if (_bulletsCount >= _bullets.GetUpperBound(0))
        {
            bulletOnTop = null;
        }
        else
        {
            bulletOnTop = _bullets[_bulletsCount];
            _bullets[_bulletsCount]= null;
            _bulletsCount++;
        }
        return bulletOnTop;
    }

}
