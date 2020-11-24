using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
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
        if(collision.gameObject.tag == "Boy")
        {
            text = "Para controlar o personagem\n utilize as setas \n" +
                   " Para Pular\n utilize a barra de espaço";
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Boy")
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

        if (text != "") { GUI.Button(new Rect(250, 150, 200, 150), text); }
    }
}
