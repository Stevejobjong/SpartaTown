using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InitNickname : MonoBehaviour
{
    [SerializeField] private TMP_Text nick;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;
    void Start()
    {
        
    }

    void Update()
    {
        if (inputField.text.Length < 2 || inputField.text.Length > 10)
            button.gameObject.SetActive(false);
        else
            button.gameObject.SetActive(true);
    }

    public void SetNickname()
    {
        nick.text = inputField.text;
        this.gameObject.SetActive(false);
    }
}
