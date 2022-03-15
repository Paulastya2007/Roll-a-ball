using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playercontroler : MonoBehaviour
{public Rigidbody rb;private float x, z;
        void Start()
    {
        rb=GetComponent<Rigidbody>();
    }
    void OnMove(InputValue tk)
    {
        Vector2 ipm = tk.Get<Vector2>();
        x = ipm.x;z=ipm.y;
    }
    void FixedUpdate()
    {
        Vector3 mt= new Vector3(x,0,z);
        rb.AddForce(mt*11);
    }
}
