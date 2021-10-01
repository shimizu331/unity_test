using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject targetObject;
    public int s = 0;//青色カウント用変数
    public int cc = 0;//一時的な変数
    public int MaxCount = 36;//cubeの数を入れておく

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        // GameObject型の配列cubesに、"box"タグのついたオブジェクトをすべて格納
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("box");
        //Debug.Log("cubes.Lengthは" + cubes.Length);

        s = 0;
        for (int i = 0; i < cubes.Length; i++)
        {
            if (cubes[i].GetComponent<Renderer>().material.color == new Color32(250, 0, 160, 130))
            {//new Color32(0, 0, 233, 130)) {
                s += 1;
            }
           // Debug.Log(s);
        }

        // if (s != MaxCount) s == 0;



        if (s == cubes.Length)
        {
            TimerScript.isComplete = true;
            cc++;
            if (cc == 1)
            {
                Debug.Log("今青です");
                // CubeプレハブをGameObject型で取得
                GameObject obj = (GameObject)Resources.Load("saveobject");
                // Cubeプレハブを元に、インスタンスを生成、
                Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity);
                cc++;
            }
        }
    }
}
