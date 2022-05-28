using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MulletCube : UdonSharpBehaviour
{
    // bullet prefab
    public GameObject bullet;
    // 弾丸発射点
    public Transform muzzle1, muzzle2;
    public float speed = 10;

    void Start()
    {
        
    }

    public override void Interact() //物体に触ると呼び出すことができる。（vrc picupでホールド状態なら呼び出されない）
    {
        Vector3 force1, force2;
        force1 = muzzle1.transform.forward * speed;
        force2 = muzzle2.transform.forward * speed;


        // 弾丸の複製
        GameObject bullets1 = VRCInstantiate(bullet);//InstantでなくVRCInstantにする
        // Rigidbodyに力を加えて発射
        bullets1.GetComponent<Rigidbody>().AddForce(force1);
        // 弾丸の位置を調整
        bullets1.transform.position = muzzle1.position;

        // 弾丸の複製
        GameObject bullets2 = VRCInstantiate(bullet);//InstantでなくVRCInstantにする
        // Rigidbodyに力を加えて発射
        bullets2.GetComponent<Rigidbody>().AddForce(force2);
        // 弾丸の位置を調整
        bullets2.transform.position = muzzle2.position;

    }

}
