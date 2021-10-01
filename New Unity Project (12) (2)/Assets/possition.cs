using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;
using System.Linq;

public class possition : MonoBehaviour
{

    public static float rPalmPosition = 0;
    public static float rThumbPosition = 0;
    public static float rIndexFingurPosition = 0;
    public static float rMiddleFingerPosition = 0;
    public static float rRingFingerPosition = 0;
    public static float rLittleFingerPosition = 0;
    public static string testi;
     public static List<string>PalmPosi=new List<string>();



    private Controller controller;
    private Finger[] fingers;
    private bool[] isGripFingers;

    // Start is called before the first frame update
    void Start()
    {

        controller = new Controller();
        fingers = new Finger[5];
        isGripFingers = new bool[5];
        List<float> v;
    }

    // Update is called once per frame
    void Update()
    {
        if (StartMeasure.MeasureStart)
        {
            Frame frame = controller.Frame();//frameにleap motionのデータを格納
            string info;//ログとして記録。infoにログを入れていく。

            List<Hand> hands = frame.Hands;//リストにframeのHnadsデータを格納。listは、配列よりも簡単に要素の追加、削除ができる
            foreach (Hand hand in hands)//handにhandsを格納。foreachは、コレクション(複数の要素)の列挙を可能にする。foreach(変数の型　変数　in コレクション)
            {
                info = "handID" + hand.Id + " isright" + hand.IsRight + "\n";
                testi += hand.PalmPosition + "\n";
                PalmPosi.Add(hand.PalmPosition.ToString());
                info += "Palm info (position:" + hand.PalmPosition + "\nVelocity:" + hand.PalmVelocity + "\n";
                info += "GrabStrenght:" + hand.GrabStrength + "  pinchStrength:" + hand.PinchStrength + "\n";
                List<Finger> fingers = hand.Fingers;
                foreach (Finger finger in fingers)
                {
                    info += "finger " + finger.Type + " dirction" + finger.Direction + " extends is" + finger.IsExtended + "tipPosition" + finger.TipPosition + "\n";

                }

                //Debug.Log(testi);
            }
        }
    }
}

