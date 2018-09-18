using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    public int rotation_speed = 1;

    void Update()
    {
            transform.Rotate(Vector3.up * Time.deltaTime * rotation_speed);
    }

    
}
