using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletContlloer : MonoBehaviour
{
    // ���x
    public float Speed;
    // �p�x
    public float Angle;
    // �ړ��x�N�g��
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        // �p�x�����W�A���ɕϊ�
        float rad = Angle * Mathf.Deg2Rad;
        // ���W�A������i�s������ݒ�
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0);
        // �����ɑ��x���|�����킹�Ĉړ��x�N�g�������߂�
        vec = direction * Speed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    // �J�����ɕ\������Ȃ��Ȃ������A��������
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
