using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _collider;
    [SerializeField] private Color32 _color;
    [SerializeField] private float _velocity;
    [SerializeField] private float _damage;
    public float Damage { get => _damage; }
    public Rigidbody2D Collider { get => _collider; set => _collider = value; }

    private void Awake()
    {
        Collider.velocity = new Vector2(-_velocity, 0f);
    }


}
