using System.Collections.Generic;
using UnityEngine;

public class UsagiIdou : MonoBehaviour
{
    /// <summary>
    /// ウサギのキャラクターを移動するコンポーネント
    /// </summary>
    /// <summary>左右移動する力</summary>
    [SerializeField] public float _movePower = 5f;
    /// <summary>入力に応じて左右を反転させるかどうかのフラグ</summary>
    [SerializeField] bool _flipX = false;
    Rigidbody2D _rb = default;
    SpriteRenderer _sprite = default;
    /// <summary>m_colors に使う添字</summary>
    int _colorIndex;
    /// <summary>水平方向の入力値</summary>
    float _h;
    float _scaleX;
    /// <summary>最初に出現した座標</summary>
    Vector3 _initialPosition;

    int count;
    bool _isJump;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        // 初期位置を覚えておく
        _initialPosition = this.transform.position;
    }

    void Update()
    {
        // 入力を受け取る
        _h = Input.GetAxisRaw("Horizontal");

        // 設定に応じて左右を反転させる
        if (_flipX)
        {
            FlipX(_h);
        }


    }

    private void FixedUpdate()
    {
        // 力を加えるのは FixedUpdate で行う
        _rb.AddForce(Vector2.right * _h * _movePower, ForceMode2D.Force);
    }

    /// <summary>
    /// 左右を反転させる
    /// </summary>
    /// <param name="horizontal">水平方向の入力値</param>
    void FlipX(float horizontal)
    {
        /*
         * 左を入力されたらキャラクターを左に向ける。
         * 左右を反転させるには、Transform:Scale:X に -1 を掛ける。
         * Sprite Renderer の Flip:X を操作しても反転する。
         * */
        _scaleX = this.transform.localScale.x;

        if (horizontal > 0)
        {
            this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
        else if (horizontal < 0)
        {
            this.transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
    }

}








