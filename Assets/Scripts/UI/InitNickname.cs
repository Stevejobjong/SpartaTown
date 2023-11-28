using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InitNickname : MonoBehaviour
{
    [SerializeField] private TMP_Text nick;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button joinBtn;
    void Start()
    {
        Time.timeScale = 0.0f;
    }

    void Update()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
            joinBtn.gameObject.SetActive(false);
        else
            joinBtn.gameObject.SetActive(true);
    }

    public void SetNickname()
    {
        nick.text = inputField.text;
        MainUI.instance.SetParticipant();
        Time.timeScale = 1.0f;
        this.gameObject.SetActive(false);
    }
    
}
