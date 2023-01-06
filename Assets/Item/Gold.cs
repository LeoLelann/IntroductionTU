using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{

    private void AddObject()
    {
        //add count pour le gold
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
