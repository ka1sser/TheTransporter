using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(255,125,0,255);
    [SerializeField] Color32 noPackageColor = new Color32(0,0,0,0);

   
    bool hasPackage;  //default bool value is false
    [SerializeField] float destroyTime=1f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Awts!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyTime);
            
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Homie!");
            spriteRenderer.color = noPackageColor;
            hasPackage = false;
        }
    }
}
