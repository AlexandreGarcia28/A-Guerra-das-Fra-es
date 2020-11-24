﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transitionlv3 : MonoBehaviour
{
    public GameObject tree;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            tree.SetActive(false);
            SceneManager.LoadScene("lv_3");
        }
    }
}

