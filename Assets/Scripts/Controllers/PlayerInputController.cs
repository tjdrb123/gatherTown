using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // ���콺 ��ǥ
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position);
        // ĳ���ͷκ��� ���콺������ ���� ���͸� ���� ��, ����ȭ �Ͽ� ���̰� 1�� �������ͷ� �����.
        CallLookEvent(newAim);
    }
}
