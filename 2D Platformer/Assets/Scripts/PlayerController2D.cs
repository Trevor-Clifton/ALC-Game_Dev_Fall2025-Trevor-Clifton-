using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController2D : MonoBehaviour
{
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
        float moveInput = Input.GetAxisRaw("Horizontal");
        if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        rig.linearVelocity = new Vector2(moveInput * moveSpeed, rig.linearVelocity.y);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
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
    }
    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
