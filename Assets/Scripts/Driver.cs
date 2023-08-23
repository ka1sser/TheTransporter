using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.05f;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0.01f, moveSpeed, 0);
    }
}
