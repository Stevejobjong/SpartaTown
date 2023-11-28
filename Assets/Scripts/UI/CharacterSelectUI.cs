using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectUI : MonoBehaviour
{
    [SerializeField] CharacterSelect cs;
    [SerializeField] private Image charactorImg;

    public void PenguinBtn()
    {
        cs.SelectCharacter(0);
        if (charactorImg.gameObject.activeSelf)
            charactorImg.sprite = Resources.Load<Sprite>("Penguin");
        this.gameObject.SetActive(false);
    }
    public void DogBtn()
    {
        cs.SelectCharacter(1);
        if (charactorImg.gameObject.activeSelf)
            charactorImg.sprite = Resources.Load<Sprite>("Dog");
        this.gameObject.SetActive(false);
    }
}
