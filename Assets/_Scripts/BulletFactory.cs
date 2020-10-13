using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public BulletController bullet;
    public BulletController fatBullet;
    public BulletController pulsingBullet;

    public BulletController createBullet(string name)
    {
        BulletController tempBullet = bullet;

        switch (name)
        {
            case "Bullet":
                tempBullet = Instantiate(bullet);
                break;
            case "Fat Bullet":
                tempBullet = Instantiate(fatBullet);
                break;
            case "PulsingBullet":
                tempBullet = Instantiate(pulsingBullet);
                break;
        }

        return tempBullet;
    }
}