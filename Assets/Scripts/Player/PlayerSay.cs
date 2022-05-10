using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSay : MonoBehaviour
{
    public GameObject SayText;
    private string Current_Text;
    private int Echo_Time = 200;
    private int Current_Time = 0;
    private bool isChange;

    private void Start()
    {
        //SayText = transform.GetChild(3).gameObject;
    }

    public void ChangeSay(string Change_Text)
    {
        if(Current_Text == Change_Text)
        {
            return;
        }
        else
        {
            //Debug.Log("ChangeSay:" + Change_Text);
            SayText.GetComponent<TextMesh>().text = Change_Text;
            Current_Time = 0;
            isChange = true;
        }
    }

    public void ChangeScene(string Scene_Name)
    {
        SceneManager.LoadScene(Scene_Name);
    }

    private void FixedUpdate()
    {
        if (isChange)
        {
            if (Current_Time <= Echo_Time)
            {
                Current_Time += 1;
            }
            else
            {
                SayText.GetComponent<TextMesh>().text = "";
                isChange = false;
            }
        }
    }

}
