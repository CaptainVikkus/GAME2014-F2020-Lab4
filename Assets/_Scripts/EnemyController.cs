using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;

    [Header("Boundary Check")]
    public float horizontalBoundary = 2.3f;

    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(direction * horizontalSpeed * Time.deltaTime, 0, 0);
    }

    private void _CheckBounds()
    {
        //check right wall
        if (transform.position.x >= horizontalBoundary)
        {
            transform.position = new Vector3(horizontalBoundary, transform.position.y, 0.0f);
            direction *= -1;
        }

        // check left wall
        if (transform.position.x <= -horizontalBoundary)
        {
            transform.position = new Vector3(-horizontalBoundary, transform.position.y, 0.0f);
            direction *= -1;
        }
    }
}
