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
        Player.GetComponent<PlayerSay>().ChangeSay("��ã�����һ����Σ�");
    }
    private void FixedUpdate()
    {
        SayTime++;
        if (SayTime > 200)
        {
            if(SayTime > 400)
            {
                NPC.GetComponent<PlayerSay>().ChangeSay("���Խ����������۶��ŵ��ٷ������ã�");
            }
            else
            {
                NPC.GetComponent<PlayerSay>().ChangeSay("> ������Ҫ�ۣ�");
            }
        }
        
    }
}
