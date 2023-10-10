using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{
    public GameObject bullet;
    Vector3 createPosition;
    private float interval = 0.2f; // 何秒間隔で撃つか
    private float timer = 0.0f;　// 時間カウント用のタイマー

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
            createPosition.y += 1.0f; // プレイヤーのy座標 + 1の位置に弾を生成する

            Instantiate(bullet, createPosition, Quaternion.identity);
        }
        transform.position = new Vector3(
            // オブジェクトが移動できる範囲の制限
            Mathf.Clamp(transform.position.x, -2.50f, 2.50f),
            Mathf.Clamp(transform.position.y, -3.5f, 3.5f),0f);
        // スペースキーを押している間、一定間隔でbulletを打ち続ける
        if (Input.GetKey(KeyCode.Space) && timer <= 0.0f)　// 分岐条件変更
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = interval; // 間隔をセット
        }
        // タイマーの値を減らす
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }
    }
}