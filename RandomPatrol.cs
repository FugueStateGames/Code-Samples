using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomPatrol : MonoBehaviour
{

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float speed;

    public GameObject deathEffect;

    Vector2 targetPosition;
    Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }

    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FaceMask")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.tag == "Chemist")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            GameMaster.Instance.GameOver();
        }

        if (collision.tag == "Goggles")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.tag == "FaceShield")
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}