using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;       // DateTimeを使うために必要
using System.IO;    // CSV保存をするために必要


public class SaveBotton : MonoBehaviour
{
   public GameObject sexObject;
    public GameObject ageObject;
    public GameObject FileNameobject;
    // public int dropdown_value;


    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
     
        int sex = sexObject.GetComponent<Dropdown>().value;
       //num=0男、num=1女
        string age = ageObject.GetComponent<InputField>().text;
        string FileName = FileNameobject.GetComponent<InputField>().text;
        var sampleData = "SampleText";
        CSVSave(sampleData,FileName,sex,age, TimerScript.countup);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CSVSave(string data, string fileName, int sex, string age,float countup)
    {
        StreamWriter sw;
        FileInfo fi;
        DateTime now = DateTime.Now;
        string sexs="a";
        if (fileName.Length == 0) fileName = fileName + now.Year.ToString() + "_" + now.Month.ToString() + "_" + now.Day.ToString() + "__" + now.Hour.ToString() + "_" + now.Minute.ToString() + "_" + now.Second.ToString(); ;
        Debug.Log(fileName);
        fi = new FileInfo(Application.dataPath + "/" + fileName + ".csv");
        sw = fi.AppendText();
        sw.WriteLine("Day," +now.Year.ToString() + "_" + now.Month.ToString() + "_" + now.Day.ToString() + "__" + now.Hour.ToString() + "_" + now.Minute.ToString() + "_" + now.Second.ToString());
        sw.WriteLine("Age," +age);
        if (sex == 0) sexs="Man";
        if (sex == 1) sexs = "Woman";
        if (sex == 2)sexs = "-";
        sw.WriteLine("Sex," +sexs);
        sw.WriteLine("RightHand");
        sw.WriteLine("Score," + countup);
        sw.WriteLine("Time,PalmPosition,,forcePalm,forceThumb...");
        sw.WriteLine("time(s),x,y,z");
        int x=TimerScript.DetaSize;
       // sw.WriteLine(data);

        for (int i = 0; i < x; i++)
        {
            sw.WriteLine(TimerScript.TimeSave[i] + "," + possition.PalmPosi[i].Trim('(', ')') + "," + TimerScript.forcePalmS[i] + "," + TimerScript.forceThumbS[i] + "," + TimerScript.forceIndexS[i] + "," + TimerScript.forceMiddleS[i] + "," + TimerScript.forceRingS[i] + "," + TimerScript.forceLittleS[i]);
            if ((i == x - 1) && (TimerScript.TimeSave[i] < (countup - 0.1)))
            {
                x++;
            }
        }
        sw.Flush();
        sw.Close();
        Debug.Log("Save Completed");
    }
}
