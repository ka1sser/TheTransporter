using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //default value is false
    bool hasPackage;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Awts!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            Debug.Log("Whatdapackage!");
            hasPackage = true;
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Homie!");
        }
    }
}
