using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
public class playercontroler : MonoBehaviour
{public Rigidbody rb;private float x, z;public int a;public Text b;public GameObject gp;
    private void OnTriggerEnter(Collider other)
    {if (other.gameObject.CompareTag("pickup"))
      {other.gameObject.SetActive(false);a++;
            b.text = a.ToString(); if (a >= 8) { 
            gp.SetActive(true);
            }
        }
    }
    void Start()
    {
        gp.SetActive(false);
        a= 0;
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
