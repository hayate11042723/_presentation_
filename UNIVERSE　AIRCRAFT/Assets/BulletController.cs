using System.Collections;
using UnityEngine;


public class BulletController : MonoBehaviour
{

    public float MoveSpeed = 1.0f;         // ˆÚ“®’l

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 5f, 0) * Time.deltaTime;
    }
}
