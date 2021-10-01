using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexTouch : MonoBehaviour
{
   int i = 0;

    Dictionary<string, float> myTable;//オブジェクト名myTable、keyにゲームオブジェクト名,valueに時間を代入
    



    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Index Hit"); // ログを表示する
                                // 赤色に変更する
        collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    // void OnTriggerEnter(Collider other)
    void OnTriggerStay(Collider other)
    {

        if (StartMeasure.MeasureStart)
        {

            if ((other.gameObject.GetComponent<Renderer>().material.color == new Color32(0, 0, 80, 130)) && (SerialHandler.forcePalm > 10))//二回目のタッチ
            {
                // Debug.Log("2回目に触ったのは" + other.gameObject.name);
                // 指定したキーが存在するかどうか
                if (myTable.ContainsKey(other.gameObject.name))
                {

                    float a = myTable[other.gameObject.name];
                    float b = TimerScript.countup;
                    float c = b - a;
                   // Debug.Log("キーに含まれています" + myTable[other.gameObject.name] + " " + TimerScript.countup + " " + c);
                    if (c > 0.8)
                    {
                        other.gameObject.GetComponent<Renderer>().material.color = new Color32(250, 0, 160, 130);//一回目のタッチから2秒たっていたらピンクにする
                    }
                }


            }


            if ((other.gameObject.GetComponent<Renderer>().material.color == new Color32(56, 56, 56, 150)) && (SerialHandler.forcePalm > 10))
            {
                other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 80, 130);//一回目のタッチ薄青色に
                myTable.Add(other.gameObject.name, TimerScript.countup);//連想配列に時間の代入

                // Debug.Log("触ったのは" + other.gameObject.name + "連想配列の値は" + myTable[other.gameObject.name]);//連想配列に一回目のタッチの時間を入れる

            }


            /*
            switch (other.gameObject.GetComponent<Renderer>().material.color)
              {
                  case color :
                      other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 233, 130);

                  case new Color32(0, 0, 233, 130):
                      other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 233, 130);

                  case new Color32(0, 0, 233, 130):
                      other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 233, 130);
              }
              other.gameObject.GetComponent<Renderer>().material.color = new Color32(0, 0, 233, 130);
              Debug.Log("すり抜けた！");
            */
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        myTable = new Dictionary<string, float>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
