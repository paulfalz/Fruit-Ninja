using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {

    public GameObject fruitSlicedPrefab;
    public float startForce = 100f;
    private ScoreManager scoreManager;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
    }



    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "blade")
        {
            Vector3 direction = (col.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            GameObject slicedFruit= Instantiate(fruitSlicedPrefab, transform.position, rotation);
            scoreManager.AddScore();
            Destroy(slicedFruit, 3f);
            Destroy(gameObject);

        }
    }

    void Stop()
    {
        GameManager.StopGame();
    }

    void OnBecameInvisible()
    {
        if (GameManager.IsPlaying)
        {
            Stop();
        }
    }

}
