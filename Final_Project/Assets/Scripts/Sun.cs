using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{ 
    private Vector3 offset;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.right * 6 * Time.deltaTime);
    }
}
