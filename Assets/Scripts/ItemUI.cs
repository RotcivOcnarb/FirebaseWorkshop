using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ItemUI : MonoBehaviour
{

    public string titulo;
    [TextArea]
    public string descricao;
    public int preco;
    public Sprite image;
    public Sprite backgroundUnlocked;
    public Sprite backgroundLocked;
    public bool locked = false;

    [Header("Referências")]

    public Text tituloText;
    public Text descricaoText;
    public Text precoText;
    public Image spriteImage;
    public Image lockIcon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloText.text = titulo;
        descricaoText.text = descricao;
        precoText.text = "" + preco;
        spriteImage.sprite = image;

        if(locked){
            GetComponent<Image>().sprite = backgroundLocked;
            lockIcon.color = new Color(1, 1, 1, 1);
        }
        else{
            GetComponent<Image>().sprite = backgroundUnlocked;
            lockIcon.color = new Color(1, 1, 1, 0);
        }
    }
}
