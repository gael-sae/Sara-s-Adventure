using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchGem : MonoBehaviour
{
    [SerializeField]
    int value = 1;

    Vector3 originalPosition;

    enum State
    {
        PLAY,
        PAUSE
    }

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {

    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("fait trigger");
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerControler>().AddGem(value);
            Debug.Log("fait add");
            Destroy(gameObject);
        }
    }
}