using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _collider;
    [SerializeField] private Color32 _color;
    [SerializeField ] private float _velocity;
    private void Start()
    {
        _collider.velocity = new Vector2(-_velocity, 0);
    }

}
