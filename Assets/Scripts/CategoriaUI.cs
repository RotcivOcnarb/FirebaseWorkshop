using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CategoriaUI : MonoBehaviour
{

    public string titulo;
    public Text tituloText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloText.text = titulo;
    }
}
