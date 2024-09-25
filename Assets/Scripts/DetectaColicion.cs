using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaColicion : MonoBehaviour
{
    void OnTriggerEnter(Collider food)
    {
        Destroy(gameObject);
        Destroy(food.gameObject);
    }

}
