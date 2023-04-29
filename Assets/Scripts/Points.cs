using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    [SerializeField]
    private Player _player;
    [SerializeField]
    private TMP_Text _text;

    private void OnScoreAdded(int score)
    {
        _text.text = score.ToString();
    }

    private void OnEnable()
    {
        _player.PointsCount += OnScoreAdded;
    }

    private void OnDisable()
    {
        _player.PointsCount -= OnScoreAdded;
    }
}
