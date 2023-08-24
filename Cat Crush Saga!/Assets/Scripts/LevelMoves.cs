using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelMoves : Level
{
    public Image Mask;
    public Button salir;
    public Button continuar;
    public TextMeshProUGUI MovCanva;
    public TextMeshProUGUI PuntFin;
    public GameObject panelFin;
    public Image star1;
    public Image star2;
    public Image star3;
    public Image barstar1;
    public Image barstar2;
    public Image barstar3;
    public int numMoves;
    public int targetScore;
    private int movesUsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.MOVES;
        Debug.Log("Numero de movimientos: " + numMoves + " Putuacion objetivo: " + targetScore);
        MovCanva.GetComponent<TextMeshProUGUI>().text = "Movimientos:\n " + (numMoves - movesUsed);
        Mask.fillAmount = (float)currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnMove()
    {
        movesUsed++;
        MovCanva.GetComponent<TextMeshProUGUI>().text = "Movimientos:\n " + (numMoves - movesUsed);
        Debug.Log("Movimientos restantes: " + (numMoves - movesUsed));

        if(numMoves-movesUsed == 0)
        {
            if (currentScore >= score1Star)
            {
                star1.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
            if(currentScore >= score2Star)
            {
                star2.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
            if (currentScore >= score3Star)
            {
                star3.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
            if (currentScore >= targetScore)
            {
                GameWin();
            }
            else
            {
                GameLose();
            }
            panelFin.SetActive(true);
        }
    }
    public override void OnPieceCleared(GamePiece piece)
    {
        base.OnPieceCleared(piece);
        puntajeCanva.GetComponent<TextMeshProUGUI>().text = "Puntaje:\n " + (currentScore);
        PuntFin.GetComponent<TextMeshProUGUI>().text = "Puntuacion: " + (currentScore);
        ActualizarBarrra(currentScore, score3Star);
        if (numMoves - movesUsed == 0)
        {
            
            if (currentScore >= targetScore)
            {
                GameWin();
                PuntFin.GetComponent<TextMeshProUGUI>().text = "Puntuacion: " + (currentScore);
            }
            else
            {
                GameLose();
                PuntFin.GetComponent<TextMeshProUGUI>().text = "Puntuacion: " + (currentScore);
            }
            if (currentScore >= score1Star)
            {
                star1.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
            if (currentScore >= score2Star)
            {
                star2.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
            if (currentScore >= score3Star)
            {
                star3.sprite = Resources.Load<Sprite>("Imagenes/estrella");
            }
        }
    }
    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
    public void ActualizarBarrra(int actual,int maximo)
    {
        float fill = (float)actual / (float)maximo;
        if (fill > 1)
        {
            Mask.fillAmount = 1;
        }
        else
        {
            Mask.fillAmount = fill;
        }
        if (currentScore >= score1Star)
        {
            barstar1.sprite = Resources.Load<Sprite>("Imagenes/estrella");
        }
        if (currentScore >= score2Star)
        {
            barstar2.sprite = Resources.Load<Sprite>("Imagenes/estrella");
        }
        if (currentScore >= score3Star)
        {
            barstar3.sprite = Resources.Load<Sprite>("Imagenes/estrella");
        }
    }
}
