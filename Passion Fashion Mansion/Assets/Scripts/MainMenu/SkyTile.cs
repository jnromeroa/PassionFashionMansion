using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyTile : MonoBehaviour
{
    [SerializeField] float xLimit = -32f;
    [SerializeField] float speed;
    Transform t;
    private void Start()
    {
        t = transform;
    }

    void Update()
    {
        Move();
        if (t.position.x<=xLimit)
        {
            Vector2 newPosition = t.position;
            newPosition.x = -newPosition.x;
            t.position = newPosition;
        }
    }
    void Move()
    {
        t.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
