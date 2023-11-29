using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    PlayerController controller;
    [SerializeField] private List<Animator> animators;
    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }
    void Start()
    {
        controller.OnMoveEvent += AnimState;
    }


    void AnimState(Vector2 dir)
    {
        animators[(int)GameManager.instance.CurCharacter].SetFloat("Speed", dir.normalized.magnitude);
    }
}
