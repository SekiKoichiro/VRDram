
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Test : UdonSharpBehaviour
{
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

            Destroy(this.gameObject);

    }
}
