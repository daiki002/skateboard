using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    float routation = 1.0f;


    
    private void Update()
    {
        transform.Rotate(new Vector3(0, routation, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    

   
}
