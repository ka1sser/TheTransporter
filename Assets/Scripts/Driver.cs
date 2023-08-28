using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float speedUp = 20f;
    [SerializeField] float speedDown = 5f;

    void Update()
    {
        //Getting the input key for the movements
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Booster")
        {
            moveSpeed = speedUp;
        }
        if(other.tag == "Slower")
        {
            moveSpeed = speedDown;
        }
    }
}
