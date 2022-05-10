using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSay : MonoBehaviour
{
    public GameObject Player;
    public GameObject NPC;
    private int SayTime = 0;

    private void Start()
    {
        Player.GetComponent<PlayerSay>().ChangeSay("你好，我是一个婉嘉！");
    }
    private void FixedUpdate()
    {
        SayTime++;
        if (SayTime > 200)
        {
            if(SayTime > 400)
            {
                NPC.GetComponent<PlayerSay>().ChangeSay("所以接下来，狗眼二号的琴房很有用！");
            }
            else
            {
                NPC.GetComponent<PlayerSay>().ChangeSay("> 我们需要眼！");
            }
        }
        
    }
}
