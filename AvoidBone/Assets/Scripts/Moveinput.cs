using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveinput : MonoBehaviour
{
    // �� �Ʒ��� �ۼ��� �ڵ�� �����Ϳ� �ش��ϴ� �����Դϴ�.
    public float moveSpeed = 5f;
    public Rigidbody2D rigid;
    //
    void Update()
    {
        // Update�� ���� �ȿ� �ڵ带 �ۼ��ϸ� ������ �����ϴ� ���߿� �� �ڵ尡 �۵��մϴ�.
        float h = Input.GetAxis("Horizontal");
        rigid.velocity = new Vector2(h * moveSpeed, 0);
    }
}
