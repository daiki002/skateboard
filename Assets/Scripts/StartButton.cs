using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject SelectPanel;

    public GameObject Player;

    public GameObject Text;

    public GameObject panel1;

    public GameObject panel2;




    public void click()
    {
        panel1.SetActive(true);
        Player.SetActive(false);
        Text.SetActive(false);

    }

    public void SelectGame(string name)
    {
        switch (name)
        {
            case "1":
                SceneManager.LoadScene("SampleScene");
                Static.MoveSpeed = 3.0f;
                Static.ClearPoint = 60;
                Static.ClearText = "60";
                break;
            case "2":
                SceneManager.LoadScene("SampleScene");

                Static.ClearPoint = 40;
                Static.ClearText = "40";
                Static.MoveSpeed = 5.0f;
                break;
            case "3":
                SceneManager.LoadScene("SampleScene");

                Static.MoveSpeed = 12.0f;
                Static.ClearText = "30";
                Static.ClearPoint = 30;
                break;
        }
    }

    public void click2()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);

    }

    public void onSelectPanel()
    {
        panel2.SetActive(false);
        SelectPanel.SetActive(true);

    }


}
