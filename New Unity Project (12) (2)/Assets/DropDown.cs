using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    public static string  COMPort= "COM1";

    //Attach this script to a Dropdown GameObject
    Dropdown m_Dropdown;
    //This is the string that stores the current selection m_Text of the Dropdown
    string m_Message;
    //This Text outputs the current selection to the screen
    public Text m_Text;
    //This is the index value of the Dropdown
    int m_DropdownValue;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the DropDown component from the GameObject
        m_Dropdown = GetComponent<Dropdown>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the current index of the Dropdown in a variable
        m_DropdownValue = m_Dropdown.value;
        //Output the first Dropdown index value
        
        if (m_Dropdown.value == 0) COMPort = "COM1";
        if (m_Dropdown.value == 1) COMPort = "COM2";
        if (m_Dropdown.value == 2) COMPort = "COM3";
        if (m_Dropdown.value == 3) COMPort = "COM4";
        if (m_Dropdown.value == 4) COMPort = "COM5";
        if (m_Dropdown.value == 5) COMPort = "COM6";
        if (m_Dropdown.value == 6) COMPort = "COM7";
        if (m_Dropdown.value == 7) COMPort = "COM8";
        if (m_Dropdown.value == 8) COMPort = "COM9";
        if (m_Dropdown.value == 9) COMPort = "COM10";
       // Debug.Log("COMPort : " + COMPort);
    }
}
