using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //カウントアップ
    public static float countup = 0.0f;
    //時間を保存する用の配列
   public  static List<float> TimeSave = new List<float>();
   public static List<float> forcePalmS = new List<float>();
   public static List<float> forceThumbS = new List<float>();
   public static List<float> forceIndexS = new List<float>();
   public static List<float> forceMiddleS = new List<float>();
   public static List<float> forceRingS = new List<float>();
   public static List<float> forceLittleS = new List<float>();
    //データサイズ保存の変数
    public static int DetaSize = 0;
    //完了したかどうか
    public static bool    isComplete = false;

    //時間を表示するText型の変数
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (StartMeasure.MeasureStart)
        {

            // Cube1-1.GetComponent<TouchCount>().TimeCount = 10;

            //全部青になったら
            if (isComplete)
            {

                DetaSize = TimeSave.Count;//全部が青になったときのデータ数を保存
                timeText.text = "結果は\n" + countup.ToString("f2") + "\n秒です";
                //クリックされた後は以降の処理を実行しないためにreturn
                return;
            }
            if (isComplete == false)
            {
                //時間をカウントする
                countup += Time.deltaTime;
                TimeSave.Add(countup);
                forcePalmS.Add(SerialHandler.forcePalm);
                forceThumbS.Add(SerialHandler.forceThumb);
                forceIndexS.Add(SerialHandler.forceIndex);
                forceMiddleS.Add(SerialHandler.forceMiddle);
                forceRingS.Add(SerialHandler.forceRing);
                forceLittleS.Add(SerialHandler.forceLittle);
                //時間を表示する
                timeText.text = countup.ToString("f1") + "秒";
            }


        }
    }
}
