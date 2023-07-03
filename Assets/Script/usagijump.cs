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
  
    Rigidbody2D _rb = default;
    
    /// <summary>水平方向の入力値</summary>
    float _h;
    float _scaleX;
    /// <summary>最初に出現した座標</summary>
    Vector3 _initialPosition;
    bool _Ground = false;
    int _count = 0;
    bool _isJump;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        // 初期位置を覚えておく
        _initialPosition = this.transform.position;
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
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
 
    {
        if (collision.gameObject.tag == "Ground")
        {
            _Ground = true;
            _count = 0;
        }
    }
}
