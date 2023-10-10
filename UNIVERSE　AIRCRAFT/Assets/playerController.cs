using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{
    public GameObject bullet;
    Vector3 createPosition;
    private float interval = 0.2f; // ���b�Ԋu�Ō���
    private float timer = 0.0f;�@// ���ԃJ�E���g�p�̃^�C�}�[

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 4.5f, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -4.5f, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(5f, 0, 0) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-5f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(0))
        {
            createPosition = transform.position;
            createPosition.y += 1.0f; // �v���C���[��y���W + 1�̈ʒu�ɒe�𐶐�����

            Instantiate(bullet, createPosition, Quaternion.identity);
        }
        transform.position = new Vector3(
            // �I�u�W�F�N�g���ړ��ł���͈͂̐���
            Mathf.Clamp(transform.position.x, -2.50f, 2.50f),
            Mathf.Clamp(transform.position.y, -3.5f, 3.5f),0f);
        // �X�y�[�X�L�[�������Ă���ԁA���Ԋu��bullet��ł�������
        if (Input.GetKey(KeyCode.Space) && timer <= 0.0f)�@// ��������ύX
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = interval; // �Ԋu���Z�b�g
        }
        // �^�C�}�[�̒l�����炷
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}