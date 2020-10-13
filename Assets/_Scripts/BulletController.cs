using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet collided with: " + other.gameObject.name);
        ApplyDamage();
        bulletManager.ReturnBullet(gameObject);
    }

    public void ApplyDamage()
    {
        switch (this.gameObject.name)
        {
            case "Bullet":
                Debug.Log("5 damage");
                break;
            case "Fat Bullet":
                Debug.Log("10 damage");
                break;
            case "PulsingBullet":
                Debug.Log("20 damage");
                break;
        }
    }
}
