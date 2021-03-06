using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VillagersPatrollingScript : MonoBehaviour
{
    //public PathType pathSystem = PathType.Linear;
    private Vector3[] points;
    //public Tween t;
    //Sequence mySeq = DOTween.Sequence();

    public Transform[] waypoints;
    private int _currentWaypointIndex = 0;
    private float _speed = 1f;
    Animator animator;

    void Start()
    {
        points = new Vector3[waypoints.Length];
        for (int i = 0; i < waypoints.Length; i++)
            points[i] = waypoints[i].position;

        transform.DOPath(points, 5).SetEase(Ease.Linear).SetLoops(-1).SetLookAt(0.01f);
        //t.SetEase(Ease.Linear).SetLoops(-1);      


        animator = GetComponent<Animator>();
        animator.SetBool("isWalk", true);
    }

    // Update is called once per frame
    void Update()
    {
        return;

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
