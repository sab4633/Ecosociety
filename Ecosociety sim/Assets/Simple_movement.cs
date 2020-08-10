using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_movement : MonoBehaviour
{

    float toX;
    float toZ;
    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = GetComponent<Rigidbody>().position;
        toX = 0f;
        toZ = 0f;
        if (Random.Range(0, 2) == 0)
      //  if(true)
        {

            toZ = 0.05f;
        }
        else
        {
            toX = 0.05f;
        }

        GetComponent<Rigidbody>().position = new Vector3(currentPos.x + toX, currentPos.y,currentPos.z + toZ);
        
    }

    
}
