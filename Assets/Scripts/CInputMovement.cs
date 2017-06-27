using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

// 입력 -> 이동하는 기능을 가진 컴포넌트
public class CInputMovement : MonoBehaviour
{
    // 경계 영역 크기 설정
    private const float LIMIT_POS_Y = 4.5f;

    private const float LIMIT_POS_X = 2.24f;

    // 속성 (특징) -> 변수

    public float _speed; // 속도

    // 메소드 (기능) -> 함수

    private void Awake()
    {
    }

    private void Update()
    {
        InputMove();
    }

    // 입력 -> 이동 기능
    public void InputMove()
    {
        // float 방향 = Input.GetAxisRaw("수평/수직")
        // 방향 : -1, 0, 1 (소수없음)
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        float h = CnInputManager.GetAxisRaw("Horizontal");
        float v = CnInputManager.GetAxisRaw("Vertical");

        // 2차원 방향 벡터 생성
        Vector2 direction = new Vector2(h, v);

        // Transform.Translate(방향벡터 * 속도 * Time.deltaTime);
        // Transform 컴포넌트에게 이동을 요청함 (위임)
        transform.Translate(direction * _speed * Time.deltaTime);

        // 화면 경계 이동 제한 처리
        Vector2 pos = transform.position;
        if (Mathf.Abs(pos.x) > LIMIT_POS_X)
        {
            pos.x = Mathf.Sign(pos.x) * LIMIT_POS_X;
        }
        if (Mathf.Abs(pos.y) > LIMIT_POS_Y)
        {
            pos.y = Mathf.Sign(pos.y) * LIMIT_POS_Y;
        }
        transform.position = pos;
    }
}