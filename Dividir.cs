using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dividir : MonoBehaviour
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
        if (collision.gameObject.tag == "div")
        {
            text = "Para dividir Frações \n" +
                   "Multiplicar a primeira fração,\n" +
                   " pelo inverso da segunda\n" +
                   "Realizar a divisão \n" +
                   "para obter o resultado final";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "div")
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

        if (text != "") { GUI.Button(new Rect(150, 50, 330, 310), text); }
    }


}
