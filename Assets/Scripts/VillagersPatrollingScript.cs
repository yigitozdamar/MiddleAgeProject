using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VillagersPatrollingScript : MonoBehaviour
{
    public Transform male_1;
    public PathType pathSystem = PathType.Linear;
    public Vector3[] points = new Vector3[2];
    public Tween t;
    Animator animator;
    //Sequence mySeq = DOTween.Sequence();

    // Start is called before the first frame update
    void Start()
    {
        t = male_1.transform.DOPath(points, 15, pathSystem);
        t.SetEase(Ease.Linear).SetLoops(-1);

        animator = GetComponent<Animator>();
        animator.SetBool("isWalk", true);

    }

    // Update is called once per frame
    void Update()
    {
        
        //mySeq.Append(transform.DOMoveX(13, 5));
        //mySeq.Append(transform.DORotate(new Vector3(0, 270, 0), 1));
        //mySeq.Append(transform.DOMoveX(-8, 5));

    }
}
