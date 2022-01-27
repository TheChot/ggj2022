using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxDestroyer : MonoBehaviour
{
    public GameObject boxToDestroy;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Destroy(boxToDestroy);
            Destroy(gameObject);
        }
        
    }
}
