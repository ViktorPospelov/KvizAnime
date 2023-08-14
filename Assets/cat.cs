using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    [SerializeField] private GameObject cry;
    [SerializeField] private Collider2D collider2D;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider == collider2D)
        {
            cry.SetActive(true);
            GameControler.EndGame?.Invoke();
        }
    }
}