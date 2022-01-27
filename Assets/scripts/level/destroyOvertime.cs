using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOvertime : MonoBehaviour
{
    public float destroyTime;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        destroyTime -= Time.deltaTime;

        if(destroyTime < 0)
        {
            Destroy(gameObject);
        }
    }
}
