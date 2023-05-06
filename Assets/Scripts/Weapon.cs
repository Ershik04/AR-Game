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
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Bullet bullet = Instantiate(_bullet, _shootPoint.transform.position, transform.rotation);
            }
        }
    }
}
