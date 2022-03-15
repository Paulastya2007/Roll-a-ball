using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject pos;public Vector3 mk;
    
    void Start()
    {
        mk = transform.position-pos.transform.position;
    } 
    void LateUpdate()
    {
        transform.position = pos.transform.position+mk;
    }
}
