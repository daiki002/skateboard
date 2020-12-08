using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    float jumpForce = 400.0f;       // ジャンプ時に加える力
    bool isGround = true;        // 地面と接地しているか管理するフラグ

    Animator anmin = null;
    Rigidbody2D rb = null;

    private bool isJumping = false;


    public Text ScoreText = null;
    public Text ClearText = null;

    int Point;

    float span = 1.0f;
    float delta = 0;
    public GameObject CoinPrefabs;

    public GameObject tag_obj = null;

    bool Stopflag;
    private void Start()
    {
        anmin = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Point = 0;
        ScoreText.text = "スコア:0";

        Stopflag = false;

        ClearText.text =  "クリアポイント:"+ Static.ClearText;

    }

    private void FixedUpdate()
    { 
       if(!Stopflag)
        {
            transform.position += new Vector3(Static.MoveSpeed*Time.deltaTime, 0, 0);

        }
    }

    private void Update()
    {
        if (!Stopflag)
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {

                this.delta = 0;
                GameObject go = Instantiate(CoinPrefabs) as GameObject;
                int px = Random.Range(-10, 70);
                go.transform.position = new Vector3(px, 5, 0);

            }
            if (this.transform.position.y < -5)
            {
                Invoke("ReturnPosition", 2.0f);
            }
         
        }
        
        
    }

    void ReturnPosition()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Move()
    {
        if (isGround && !isJumping)
        {
            
                this.rb.AddForce(transform.up * this.jumpForce);
                isGround = false;
                isJumping = true;
                anmin.SetBool("jump", true);
        }


    }

    

    //着地判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("ok");
            if (!isGround)
                isGround = true;
                isJumping = false;
            anmin.SetBool("jump", false);
            anmin.SetBool("ground", true);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (!isGround)
                isGround = true;
            //isJumping = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            AddPoint();
        }
    }

    public void AddPoint()
    {
        Point += 10;
        ScoreText.text = "Score:" + Point.ToString();
        if (Static.ClearPoint == Point)
        {
            Stopflag = true;
            Invoke("OnClearpanel", 1.3f);
        }
    }

    void OnClearpanel()
    {
        SceneManager.LoadScene("Clear");

    }
}
