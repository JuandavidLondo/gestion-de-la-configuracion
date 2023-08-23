using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMoves : Level
{
    public Button salir;
    public Text MovCanva;
    public int numMoves;
    public int targetScore;
    private int movesUsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        type = LevelType.MOVES;
        Debug.Log("Numero de movimientos: " + numMoves + " Putuacion objetivo: " + targetScore);
        MovCanva.text = "Movimientos:\n " + (numMoves - movesUsed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnMove()
    {
        movesUsed++;
        MovCanva.text = "Movimientos:\n " + (numMoves - movesUsed);
        Debug.Log("Movimientos restantes: " + (numMoves - movesUsed));

        if(numMoves-movesUsed == 0)
        {
            if(currentScore >= targetScore)
            {
                GameWin();
            }
            else
            {
                GameLose();
            }
        }
    }
    public override void OnPieceCleared(GamePiece piece)
    {
        base.OnPieceCleared(piece);
        puntajeCanva.text= "Puntaje:\n " + (currentScore);
    }
    public void Salir()
    {
        SceneManager.LoadScene(0);
    }
}
