using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodigoCaixaCerta : MonoBehaviour
{
    public GameObject caixaCerta;

    public GameObject muro1;


    public GameObject caixaCerta2;

    public GameObject muro2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "caixaCerta")
        {
            muro1.SetActive(false);
        }
        else
        {
            if(col.gameObject.tag == "caixaCerta2")
            {
                muro2.SetActive(false);
            }
        }
    }
}
