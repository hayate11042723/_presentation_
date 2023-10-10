using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用


public class EnemyBullet3 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3.0f;                   // 移動値
    [SerializeField] Vector3 moveVec = new Vector3(0, 0, 0);  // 移動方向
    Vector3 playerPos;//playerの座標を入れる変数
    GameObject player;
    Vector3 arrows;

    private void Start()
    {
        player = GameObject.Find("player");
        playerPos = player.transform.position;
        arrows = (playerPos - this.transform.position).normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        transform.position += arrows / 10;
        if (transform.position.y < -5.0f || transform.position.x < -5.0f || transform.position.x > 5.0f)
        {
            Destroy(gameObject);
        }

    }

    public void SetMoveSpeed(float _speed)
    {
        moveSpeed = _speed;
    }

    public void SetMoveVec(Vector3 _vec)
    {
        moveVec = _vec.normalized;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            // 爆発エフェクトを生成する	
            Destroy(coll.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
        else
        {

        }

    }
}