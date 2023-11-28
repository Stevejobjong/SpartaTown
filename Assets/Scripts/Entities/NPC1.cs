using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : MonoBehaviour
{
    [SerializeField] GameObject InteractUI;
    [SerializeField] GameObject TalkNPC1;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TalkNPC()
    {
        Time.timeScale = 0.0f;
        TalkNPC1.SetActive(true);
        InteractUI.SetActive(false);
    }
    public void CancelTalkNPC()
    {
        TalkNPC1.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void CancelInteract()
    {
        InteractUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InteractUI.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            InteractUI.SetActive(false);
        }
    }

}
