using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Somar : MonoBehaviour
{
    string text = "";


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "adi")
        {
            text = "Para Somar Frações \n Identificar se o denominadores são iguais\n sendo iguais \n" +
                   " Repete-se o denominador \n E iremos somar os numeradores";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "adi")
        {
            text = "";
        }
    }

    private void OnGUI()
    {
        GUIStyle gui = new GUIStyle();
        GUI.contentColor = Color.yellow;
        gui.fontSize = 50;
        gui.fontStyle = FontStyle.Bold;

        if (text != "") { GUI.Button(new Rect(250, 150, 260, 150), text); }
    }
}
