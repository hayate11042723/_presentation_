using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    float fallSpeed;
    float rotSpeed;
    float timer;
    public GameObject tamas;

    void Start()
    {
        this.fallSpeed = (0.03f + 0.05f * Random.value)/4;
        this.rotSpeed = 2f + 1f * Random.value;
    }

    void FixedUpdate()
    {
        transform.Translate(0, -fallSpeed, 0, Space.World);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }

        if(timer > 1.5f)
        {
            Instantiate(tamas, this.transform.position, Quaternion.identity);
            timer = 0;
        }

        //timer
        timer += Time.deltaTime;
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // 当たったのがプレイヤーの弾
        if (other.gameObject.CompareTag("Player_Bullet"))
        {
            // 自身を消す
            Destroy(gameObject);

            // 弾も消す
            Destroy(other.gameObject);
        }
    }
   

}