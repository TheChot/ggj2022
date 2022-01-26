using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSwitch : MonoBehaviour
{
    public playerMovement[] pM;
    public KeyCode switchChar;
    // Start is called before the first frame update
    void Start()
    {
        pM[0].canMove = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(switchChar)){
            for (int i = 0; i < pM.Length; i++)
            {
                pM[i].canMove = !pM[i].canMove;
            }
        }
    }
}
