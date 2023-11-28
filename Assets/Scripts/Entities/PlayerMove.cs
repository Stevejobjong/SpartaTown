using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    [SerializeField] private List<Animator> _animators;
    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        print("start");
        _controller.OnMoveEvent += Move;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    private void Move(Vector2 dir)
    {
        print("Move »£√‚µ ");
        _movementDirection = dir;
    }
    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * 5;
        _animators[(int)GameManager.instance.CurCharacter].SetFloat("Speed", dir.normalized.magnitude);
        _rigidbody.velocity = dir;
    }
}
