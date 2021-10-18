using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VillagersPatrollingScript : MonoBehaviour
{
    //public Transform male_1;
    //public PathType pathSystem = PathType.Linear;
    //public Vector3[] points = new Vector3[2];
    //public Tween t;
    //Sequence mySeq = DOTween.Sequence();

    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    private float _speed = 1f;
    Animator animator;

    void Start()
    {
        //t = male_1.transform.DOPath(points, 15, pathSystem);
        //t.SetEase(Ease.Linear).SetLoops(-1);      

        animator = GetComponent<Animator>();
        animator.SetBool("isWalk", true);

    }

    // Update is called once per frame
    void Update()
    {
        Transform wp = waypoints[_currentWaypointIndex];
        if (Vector3.Distance(transform.position, wp.position) < 0.1f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                wp.position,
                _speed * Time.deltaTime);
            transform.LookAt(wp.position);
        }


    }
}
