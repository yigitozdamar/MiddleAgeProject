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

    // Start is called before the first frame update
    void Start()
    {
        
        t = male_1.transform.DOPath(points, 15, pathSystem);
        t.SetEase(Ease.Linear).SetLoops(-1);
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
}
