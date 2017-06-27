using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 입력 -> 발포 기능 컴포넌트
public class CInputShot : MonoBehaviour
{
    // 레이저 프리팹
    public GameObject _laserPrefab;

    // 발포 위치 배열
    public Transform[] _shotPoints;

    // 총알 발포 갯수
    public int _shotCount = 1;

    private void Update()
    {
        // 왼쪽 키를 누르면
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Shot(); // 발포
        }
    }

    // 발포 메소드
    public void Shot()
    {
        // 발포 위치별로 총알을 발포 방향으로 발포함
        for (int i = 0; i < _shotCount; i++)
        {
            Instantiate(_laserPrefab, _shotPoints[i].position,
                _shotPoints[i].rotation);
        }
    }
}