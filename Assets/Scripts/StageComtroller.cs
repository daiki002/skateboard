using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageComtroller : MonoBehaviour
{

    [Header("プレイヤーゲームオブジェクト")] public GameObject Playerobj;
    [Header("コンテニュー位置")] public GameObject [] ContinuePoint;
    // Start is called before the first frame update
    void Start()
    {
        if (Playerobj != null && ContinuePoint !=null && ContinuePoint.Length > 0)
        {
            Playerobj.transform.position = ContinuePoint[0].transform.position;
        }
        else if (Playerobj.transform.position.y < -5)
        {
            Playerobj.transform.position = ContinuePoint[0].transform.position;
        }
    }

  

    // Update is called once per frame
    void Update()
    {
        
    }
}
