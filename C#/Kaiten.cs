
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaiten : UdonSharpBehaviour
{
    GameObject P1;
    public float aa;

    void Start()
    {
        
    }

    void Update()
    {
        P1 = GameObject.Find("Kaiten1");//Kaitenを見つける
        Suitti p1 = P1.GetComponent<Suitti>();//Kaitenのプログラムを読み取る
        aa = p1.aa;//ここでKaitenのaaの値を取得　→　何回押したかを感知する

        if (aa % 2 == 1)
        {
            transform.Rotate(new Vector3(0, 0.1f, 0));
        }
    }

}
