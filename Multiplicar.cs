using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplicar : MonoBehaviour
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
        if (collision.gameObject.tag == "multi")
        {
            text = "Para multiplicar Frações \n" +
                   "Multiplicar os denominadores entre si\n" +
                   "Multiplicar os numeradores entre si";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "multi")
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

        if (text != "") { GUI.Button(new Rect(250, 150, 250, 150), text); }
    }


}
