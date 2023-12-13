using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB; 
    public Transform player;
    public float stopDistance = 2.0f;
    public float speed = 5f;

    private Transform target;
    public Animator animator;

    void Start()
    {
        target = pointA;
    }

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= stopDistance)
        {
            animator.SetFloat("Speed", 0f);
            return;
        }

        animator.SetFloat("Speed", 1f);

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == pointA)
                target = pointB;
            else
                target = pointA;
           
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;
        }
    }
}