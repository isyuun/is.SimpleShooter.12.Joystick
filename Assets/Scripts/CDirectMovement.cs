using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 직선 이동 클래스
public class CDirectMovement : MonoBehaviour
{
    public Vector2 _direction; // 이동 방향

    public float _speed; // 이동 속도

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        // 지정한 방향으로 단위 속도만큼 이동함
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}