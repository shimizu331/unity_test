using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class SerialHandler : MonoBehaviour
{
    public static int forcePalm=0;
    public static int forceThumb = 0;
    public static int forceIndex = 0;
    public static int forceMiddle = 0;
    public static int forceRing = 0;
    public static int forceLittle = 0;
    SerialPort Port1 = new SerialPort(DropDown.COMPort, 9600);
   //SerialPort Port1 = new SerialPort("COM3", 9600);

  int data;
    string str="0";
    void Start() {
        if (Port1.IsOpen)
        {
            Port1.Close();
        }
        else {
            Port1.Open();
            Port1.ReadTimeout=1000;
            Debug.Log("dataなし");
        }
    }

    void Update() {
       // Debug.Log("COMPort : " + COMPort);
        data = 0;
        // data = Port1.ReadByte();
        int count = Port1.BytesToRead;
        //str = "0";
        if (count > 0)
        {
            str = Port1.ReadLine();
        }
        string[] lines = str.Split(',');

        // Debug.Log("力の大きさは"+str);
        forcePalm = 100;//int.Parse(lines[0]);
        forceThumb = int.Parse(lines[1]);
        forceIndex = int.Parse(lines[2]);
        forceMiddle = int.Parse(lines[3]);
        forceRing = int.Parse(lines[4]);
        forceLittle = int.Parse(lines[5]);
       // Debug.Log("  " + forcePalm+"  " + forceThumb+"  " + forceIndex+"  " + forceMiddle+"  " + forceRing+"  " + forceLittle);
       // force = 100;
    }
}