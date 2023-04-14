using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    private Movement2D movement2D;
    [SerializeField] private StageData floor;

    private void Awake()
    {
        movement2D = transform.GetComponent<Movement2D>();
    }

    private void LateUpdate()
    {
        //�÷��̾ ȭ�� ���� �ٱ����� ������ ���ϵ��� ����
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, floor.LimitMin.x, floor.LimitMax.x),
            Mathf.Clamp(transform.position.y, floor.LimitMin.y, floor.LimitMax.y),
            0f
            );
    }
}
