
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Suitti : UdonSharpBehaviour
{
    public float aa,bb;
    void Start()
    {
        
    }
    public override void Interact() //物体に触ると呼び出すことができる。（vrc picupでホールド状態なら呼び出されない）
    {
        aa += 1;
    }

    public void Update()
    {
        Vector3 tmp = this.transform.position;
        bb = tmp.y;
    }

    

}
