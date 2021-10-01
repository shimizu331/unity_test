using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ForceIn : MonoBehaviour
{
        //時間を表示するText型の変数
    public Text ForceText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ForceText.text = SerialHandler.forcePalm + "力";//いる？
    }
}
