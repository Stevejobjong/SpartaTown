using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : PlayerController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        //마우스 스크린 좌표
        Vector2 mPos = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(mPos);
        mPos = (worldPos - (Vector2)transform.position).normalized;

        if (mPos.magnitude > .9f)
        {
            CallLookEvent(mPos);
        }
    }
}
