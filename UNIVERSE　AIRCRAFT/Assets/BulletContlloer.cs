using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletContlloer : MonoBehaviour
{
    // 速度
    public float Speed;
    // 角度
    public float Angle;
    // 移動ベクトル
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        // 角度をラジアンに変換
        float rad = Angle * Mathf.Deg2Rad;
        // ラジアンから進行方向を設定
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0);
        // 方向に速度を掛け合わせて移動ベクトルを求める
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
    // カメラに表示されなくなった時、消去する
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
