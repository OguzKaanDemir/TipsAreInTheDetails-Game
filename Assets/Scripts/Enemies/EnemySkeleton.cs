using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeleton : MonoBehaviour
{
    public string Yon;
    public float speed = 2f;
    private Rigidbody2D rb;
    LevelsPanelScript levelsPanelScript;


    private void Awake()
    {
        levelsPanelScript = FindObjectOfType<LevelsPanelScript>();
    }

    private void Update()
    {
        Destroy(this.gameObject, 7f);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Yon == "L")
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Yon == "Y")
        {
            rb.velocity = new Vector2(0, speed);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            collision.transform.position = levelsPanelScript.newsPositions[levelsPanelScript.levelIndex];
        }
    }
}
