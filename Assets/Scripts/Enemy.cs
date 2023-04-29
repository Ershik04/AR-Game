using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private GameObject _particles;
    [SerializeField]
    public event UnityAction<Enemy> Dying;
    
    public void EnemyDestroy()
    {
        Dying?.Invoke(this);
        Instantiate(_particles);
        Destroy(gameObject);
    }
}
