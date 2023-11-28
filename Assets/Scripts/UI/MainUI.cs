using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MainUI : MonoBehaviour
{
    public TMP_Text timetxt;
    [SerializeField] GameObject characterSelectUI;
    [SerializeField] GameObject InitNameUI;
    void Update()
    {
        timetxt.text = DateTime.Now.ToString(("HH:mm:ss"));
    }

    public void ShowCharacterSelectUI()
    {
        characterSelectUI.SetActive(true);
    }
    public void ShowInitNameUI()
    {
        InitNameUI.SetActive(true);
    }
}
