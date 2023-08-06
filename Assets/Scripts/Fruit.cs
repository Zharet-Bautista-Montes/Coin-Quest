using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit: MonoBehaviour
{
    AudioSource sonido;
    void Start()
    {
        sonido = GetComponent<AudioSource>();
        GetComponent<SpriteRenderer>().enabled = true;
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sonido.Play();
            ScoreManager.SumScore(1);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.5f);
        }
    }
}
