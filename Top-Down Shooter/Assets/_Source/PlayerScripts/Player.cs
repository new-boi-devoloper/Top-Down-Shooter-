using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [field: Header("Player Stats")]
    
    [field: SerializeField] public float PlayerSpeed { get; private set; }
    [field: SerializeField] public float PlayerRotation { get; private set; }

    
    [field: Header("Player weapons")]
    
    // [field:SerializeField] public GameObject bulletPrefab { get; private set; }

    
    public Rigidbody Rb { get; private set; }

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    
    
}
