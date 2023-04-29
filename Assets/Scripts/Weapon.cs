using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private Bullet _bullet;
    [SerializeField]
    private GameObject _shootPoint;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Bullet bullet = Instantiate(_bullet, _shootPoint.transform.position, transform.rotation);
        }
    }
}
