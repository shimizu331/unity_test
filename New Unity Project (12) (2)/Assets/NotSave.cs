using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotSave : MonoBehaviour
{
    // 破棄するオブジェクトへの参照を保持します。
    public GameObject targetObj;
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        // 引数のGameObjectを破棄します。
        Destroy(targetObj);
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
