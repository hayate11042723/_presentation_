using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClaerTime : MonoBehaviour
{
    private float step_time;    // 経過時間カウント用

    // Use this for initialization
    void Start()
    {
        step_time = 0.0f;       // 経過時間初期化
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 経過時間をカウント
        step_time += Time.deltaTime;

        // 360秒後に画面遷移（scene2へ移動）
        if (step_time >= 360.0f)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
