using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Prieba : MonoBehaviour
{
    public GameObject PanelNiv;
    public Text NombNivel;
    public Image obetivo;
    public int Nivel;
    public Scene nivel1;
    public void Start()
    {
        obetivo.GetComponent<Image>();
    }
    public void Mensaje()
    {
        Debug.Log("Funcionando");
    }
    public void mostrarTexto()
    {
        PanelNiv.SetActive(true);
        NombNivel.text = "Nivel 1";
        obetivo.GetComponent<Image>();
        obetivo.sprite = Resources.Load<Sprite>("Imagenes/fichaAzul");
        Nivel = 1;
        Debug.Log("Has pulsado");
    }
    public void nivel2()
    {
        PanelNiv.SetActive(true);
        NombNivel.text = "Nivel 2";
        obetivo.sprite = Resources.Load<Sprite>("Imagenes/Ficha huella amarilla");
        Nivel = 2;
        Debug.Log("Nivel2");
    }
    public void nivel3()
    {
        PanelNiv.SetActive(true);
        NombNivel.text = "Nivel 3";
        obetivo.sprite = Resources.Load<Sprite>("Imagenes/Ficha bola de estambre");
        Nivel = 3;
        Debug.Log("Nivel3");
    }
    public void nivel4()
    {
        PanelNiv.SetActive(true);
        NombNivel.text = "Nivel 4";
        obetivo.sprite = Resources.Load<Sprite>("Imagenes/Ficha gato rosa");
        Nivel = 4;
        Debug.Log("Nivel4");
    }
    public void Cerrar()
    {
        PanelNiv.SetActive(false);
    }
    public void Jug1()
    {
        if (Nivel == 1)
        {
            SceneManager.LoadScene(1);
            Debug.Log("Yendo al 1");
        }else if (Nivel == 2)
        {
            Debug.Log("Yendo al 2");
        }
        else if (Nivel == 3)
        {
            Debug.Log("Yendo al 3");
        }
        else if (Nivel == 4)
        {
            Debug.Log("Yendo al 3");
        }
    }
}
