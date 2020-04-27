using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScriptTime : MonoBehaviour
{
    public Text Contador;
    public Text fin;
    private float tiempo = 10f;


    // Start is called before the first frame update
    void Start()
    {
        Contador.text = "" + tiempo;
        fin.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        Contador.text = " " + tiempo.ToString("f0") ;

        if (tiempo <= 0)
        {
            Contador.text = "0";
            fin.enabled = true;
        }
    }
}
