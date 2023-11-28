using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MainUI : MonoBehaviour
{
    public static MainUI instance = null;
    public TMP_Text timetxt;
    public TMP_Text people;
    public GameObject[] Players;
    [SerializeField] GameObject characterSelectUI;
    [SerializeField] GameObject InitNameUI;
    [SerializeField] GameObject ParticipantUI;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }
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
        Time.timeScale = 0.0f;
        InitNameUI.SetActive(true);
    }
    public void ShowParticipant()
    {
        SetParticipant();
        ParticipantUI.SetActive(true);
    }
    public void HideParticipant()
    {
        ParticipantUI.SetActive(false);
    }
    public void SetParticipant()
    {
        Players = GameObject.FindGameObjectsWithTag("Name");
        people.text = "";
        for (int i = 0; i < Players.Length; i++)
        {
            people.text += Players[i].GetComponent<TMP_Text>().text + '\n';
        }
    }
}
