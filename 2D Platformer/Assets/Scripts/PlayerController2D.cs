using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController2D : MonoBehaviour
{

    bool walled = false;
    private float moveInput;

    [Header("PLayer Settings")]
    public float moveSpeed;
    public float jumpForce;
    public bool isGrounded;
    public int bottomBound = -4;
    [Header("Score")]
    public int score;

    public Rigidbody2D rig;
    public TextMeshProUGUI scoreText;

    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
    

    // Update is called once per frame

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
            else if (walled)
            {
                print("did the thing");
                rig.AddForce(new Vector2(-1, 1) * 5, ForceMode2D.Impulse);
                walled = false;
            }
        }
        if (!walled)
        {
            rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
        }
        if (transform.position.y < bottomBound)
        {
            GameOver();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
        if(collision.gameObject.tag == "Wall")
        {
            walled = true;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
