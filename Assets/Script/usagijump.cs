using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsagiJump : MonoBehaviour
{
    /// <summary>
    /// ウサギのキャラクターをジャンプするコンポーネント
    /// </summary>
    /// <summary>左右移動する力</summary>
    [SerializeField] public float _moveJumpPower = 5f;
    /// <summary>ジャンプする力</summary>
    [SerializeField] public float _jumpPower = 15f;
    [SerializeField] float _wateTime = 0;

    Rigidbody2D _rb = default;

    /// <summary>水平方向の入力値</summary>
    private float _h;
    int _count = 0;

    IEnumerator Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        enabled = false;
        yield return new WaitForSeconds(_wateTime);
        enabled = true;
    }

    void Update()
    {
        // 入力を受け取る
        _h = Input.GetAxisRaw("Horizontal");

        // 各種入力を受け取る
        if (Input.GetKeyDown(KeyCode.Space)&& _count < 1)
        {
            _rb.AddForce(Vector2.up * _moveJumpPower, ForceMode2D.Impulse);
            _count++;
            GetComponent<AudioSource>().Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
           // _Ground = true;
            _count = 0;
        }
    }
}
