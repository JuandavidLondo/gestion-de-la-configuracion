using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Prieba : MonoBehaviour
{
    public GameObject PanelNiv;
    public GameObject NombNivel;
    public GameObject objetivoNivel;
    public GameObject obetivo;
    public int Nivel;
    public Scene nivel1;
    public void Start()
    {

    }
    public void Mensaje()
    {
        Debug.Log("Funcionando");
    }
    public void mostrarTexto()
    {
        PanelNiv.SetActive(true);
        NombNivel.GetComponent<TextMeshProUGUI>().text = "Nivel 1";
        objetivoNivel.GetComponent<TextMeshProUGUI>().text = "20000 Puntos";
        obetivo.SetActive(false);
        objetivoNivel.SetActive(true);
        Nivel = 1;
        Debug.Log("Has pulsado");
    }
    public void nivel2()
    {
        PanelNiv.SetActive(true);
        NombNivel.GetComponent<TextMeshProUGUI>().text = "Nivel 2";
        obetivo.SetActive(true) ;
        objetivoNivel.SetActive(false);
        obetivo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Imagenes/Ficha huella amarillla");
        Nivel = 2;
        Debug.Log("Nivel2");
    }
    public void nivel3()
    {
        PanelNiv.SetActive(true);
        NombNivel.GetComponent<TextMeshProUGUI>().text = "Nivel 3";
        obetivo.SetActive(true);
        objetivoNivel.SetActive(false);
        obetivo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Imagenes/Ficha bola de estambre");
        Nivel = 3;
        Debug.Log("Nivel3");
    }
    public void nivel4()
    {
        PanelNiv.SetActive(true);
        NombNivel.GetComponent<TextMeshProUGUI>().text = "Nivel 4";
        obetivo.SetActive(true);
        objetivoNivel.SetActive(false);
        obetivo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Imagenes/Ficha gato rosa");
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
