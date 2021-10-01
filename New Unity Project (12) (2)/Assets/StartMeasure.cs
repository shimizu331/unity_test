using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMeasure : MonoBehaviour
{
    public static bool MeasureStart = false;
    public void OnClick()
    {
        Debug.Log("押された!");  // ログを出力
        MeasureStart = true;
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
