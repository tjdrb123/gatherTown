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
        Vector2 newAim = value.Get<Vector2>(); // 마우스 좌표
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);

        newAim = (worldPos - (Vector2)transform.position);
        // 캐릭터로부터 마우스까지의 방향 벡터를 얻은 후, 정규화 하여 길이가 1인 단위벡터로 만든다.
        CallLookEvent(newAim);
    }
}
