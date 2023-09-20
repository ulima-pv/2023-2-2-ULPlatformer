using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float rayDistance = 3f;

    [SerializeField]
    private float speed = 4f;
    [SerializeField]
    private Transform raycastPoint;

    private Vector2 direction = Vector2.right;
    private Transform player;
    private Rigidbody2D rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    private void Update() 
    {
        RaycastHit2D hit =  Physics2D.Raycast(
            transform.position,
            direction,
            rayDistance
        );  

        Debug.DrawRay(
            transform.position,
            transform.right * rayDistance,
            Color.red
        );

        if (hit)
        {
            player = hit.collider.transform;
            Attack();
        }

        if (ShouldFall())
        {
            rb.velocity = new Vector2(
                0f,
                rb.velocity.y
            );
        }
    }

    private bool ShouldFall()
    {
        Vector2 dir = new Vector2(1f, -1f);
        RaycastHit2D hit = Physics2D.Raycast(
            raycastPoint.position,
            dir.normalized,
            2f
        );

        Debug.DrawRay(
            raycastPoint.position,
            dir.normalized * 2f,
            Color.blue
        );

        if (hit) return false;
        else return true;
    }

    private void Attack()
    {
        rb.velocity = new Vector2(
            speed,
            rb.velocity.y
        );
    }
}
