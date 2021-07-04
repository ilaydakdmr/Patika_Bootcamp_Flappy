using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public bool isdead;
    public float velocity = 1f;
    public Rigidbody2D rgbd2D;
    public GameManager managerGame;
    public GameObject GameOver;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rgbd2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="ForScore")
        {
            managerGame.UpdateScore();
            GameOver.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Death")
        {
            isdead = true;
            Time.timeScale = 0;
            
        }
    }
}
