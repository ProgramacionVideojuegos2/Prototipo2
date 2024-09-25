using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float inputHor;
    float velocidad = 20;
    public GameObject foodProyectil;

    void Start()
    {
        
    }

    
    void Update()
    {
        

        if(transform.position.x < -20){
            transform.position = new Vector3 (-20, transform.position.y, transform.position.z);
        }else if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProyectil, gameObject.transform.position, foodProyectil.transform.rotation);
        }

        inputHor = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime * velocidad* inputHor);
    }
}
