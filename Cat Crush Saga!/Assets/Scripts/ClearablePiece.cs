using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearablePiece : MonoBehaviour
{
    public AnimationClip clearAnimation;
    private bool isBeingClear = false;
    public bool IsBeingCleared
    {
        get { return isBeingClear; }
    }
    protected GamePiece piece;
    private void Awake()
    {
        piece = GetComponent<GamePiece>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void Clear()
    {
        piece.Gridref.level.OnPieceCleared(piece);
        isBeingClear = true;
        StartCoroutine(ClearCoroutine());
    }
    private IEnumerator ClearCoroutine()
    {
        Animator animator = GetComponent<Animator>();
        if (animator)
        {
            animator.Play(clearAnimation.name);
            yield return new WaitForSeconds(clearAnimation.length);
            Destroy(gameObject);
        }
    }
}
