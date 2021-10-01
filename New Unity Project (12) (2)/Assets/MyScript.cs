using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour

{
    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)//collisionオブジェクトには、当たったオブジェクト
    {

        Debug.Log("Hit"); // ログを表示する
                         
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
