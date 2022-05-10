using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestDoor : MonoBehaviour
{
    public GameObject TipText;
    public string SceneName;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerSay>().ChangeSay("ÎÒÀ´ÕÒ¹·ÑÛ¸ç¸ç¸ã»ùÀ±£¡");
            TipText.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TipText.SetActive(false);
        }
    }

    private void Update()
    {
        
        if(Input.GetAxis("Use_E")>0)
        {
            if (TipText.activeSelf)
            {
                Debug.Log("SceneChange");
                SceneManager.LoadScene(SceneName);
            }
        }
    }
}
