using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_movement : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = GetComponent<Rigidbody>().position;
        GetComponent<Rigidbody>().position = new Vector3(currentPos.x + 0.05f, currentPos.y,currentPos.z+0.05f);
    }
}
