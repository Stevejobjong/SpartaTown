using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 dir)
    {
        print("�̺�Ʈ ȣ���");
        OnMoveEvent?.Invoke(dir);
    }
    public void CallLookEvent(Vector2 dir)
    {
        OnLookEvent?.Invoke(dir);
    }
}
