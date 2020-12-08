using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    bool flag;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag )
        {
            Playerjump();
        }
    }

    public void Onclick()
    {
        flag = true;
    }

    public void OffClick()
    {
        flag = false;
    }


    void Playerjump()
    {
        player.Move();
    }
}
