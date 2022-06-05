using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    private Rigidbody2D rb;
    private float rate = 0.01f;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log(other);
        if (other.gameObject.name == "rabbit")
        {
            other.SendMessage("drink", rate);
        }
    }
}
