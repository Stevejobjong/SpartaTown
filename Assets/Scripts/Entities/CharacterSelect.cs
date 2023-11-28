using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField] List<GameObject> characterSprites;

    void Start()
    {
        if (characterSprites != null)
        {
            characterSprites[0].SetActive(true);
            for (int i = 1; i < characterSprites.Count; i++)
                characterSprites[i].SetActive(false);
        }
    }

    public void SelectCharacter(int idx)
    {
        if (characterSprites.Count < idx + 1)
            return;
        for(int i = 0; i < characterSprites.Count; i++)
        {
            if (i == idx)
                continue;
            characterSprites[i].SetActive(false);
        }
        characterSprites[idx].SetActive(true);
        GameManager.instance.CurCharacter = (GameManager.animal)idx;
    }

}
