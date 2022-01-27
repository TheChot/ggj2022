using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public float speed;
    // public string layerString;
    
    void FixedUpdate()
    {
        transform.position += (transform.right * Time.fixedDeltaTime * speed);        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("destructible"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }

        
    }
}
