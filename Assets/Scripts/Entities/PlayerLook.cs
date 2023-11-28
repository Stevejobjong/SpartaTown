using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private List<SpriteRenderer> characterRenderers;

    private PlayerController _controller;
    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }
    void Start()
    {
        _controller.OnLookEvent += Look;
    }

    private void Look(Vector2 dir)
    {
        RotatePlayer(dir);
    }

    // Update is called once per frame
    private void RotatePlayer(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        characterRenderers[(int)GameManager.instance.CurCharacter].flipX = Mathf.Abs(rotZ) > 90f;
    }
}
