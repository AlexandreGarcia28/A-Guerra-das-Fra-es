using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionLv4 : MonoBehaviour
{
    public GameObject TaillBuilding;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            TaillBuilding.SetActive(false);
            SceneManager.LoadScene("lv_4");
        }
    }
}

