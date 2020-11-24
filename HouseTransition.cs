using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseTransition : MonoBehaviour
{
    public GameObject house;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            house.SetActive(false);
            SceneManager.LoadScene("lv_2");
        }
    }
}

