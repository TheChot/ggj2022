using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireThrower : MonoBehaviour
{
    playerMovement pM;
    public KeyCode fireBtn;
    public Transform firePos;
    public GameObject fireball;
    void Start()
    {
        pM = GetComponent<playerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pM.canMove)
        {
            if(Input.GetKeyDown(fireBtn))
            {
                GameObject _fireball = (GameObject)Instantiate(fireball, firePos.position, firePos.rotation);  
            }
        }
    }
}
