using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SerialForceSensor : MonoBehaviour
{
    /*
    public SerialHandler serialHandler;
    private char ch;
    public int data;

    // Start is called before the first frame update
    void Start()
    {
        serialHandler.OnDataReceived += OnDataReceived;
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnDataReceived(string message)
    {
        try
        {
            ch = message[0];
            message = message.Remove(0, 1);

            switch (ch)
            {
                case 'a':
                    data = float.Parse(message);
                    serialHandler.Write(data);
                    break;
            }


        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }

    }

    */
}