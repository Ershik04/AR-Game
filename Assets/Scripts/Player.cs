using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int _points;
    public event UnityAction<int> PointsCount;

    public void AddScore()
    {
        _points++;
        PointsCount?.Invoke(_points);
    }
}
