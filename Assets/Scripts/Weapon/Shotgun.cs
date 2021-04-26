using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _delay;

    private float _timeAfterShoot;

    public override void Shoot(Transform shootPoint)
    {
        if (_timeAfterShoot < _delay)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            _timeAfterShoot = _delay;
        }
        else
        {
            _timeAfterShoot -= Time.deltaTime;
        }
    }
}