using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClaerTime : MonoBehaviour
{
    private float step_time;    // �o�ߎ��ԃJ�E���g�p

    // Use this for initialization
    void Start()
    {
        step_time = 0.0f;       // �o�ߎ��ԏ�����
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // �o�ߎ��Ԃ��J�E���g
        step_time += Time.deltaTime;

        // 360�b��ɉ�ʑJ�ځiscene2�ֈړ��j
        if (step_time >= 360.0f)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
