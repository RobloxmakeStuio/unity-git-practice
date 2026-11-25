
using UnityEngine;

public class EnemyA : Enemy
{
    Rigidbody2D rigid;
    Vector2 startPos;

    float timer;
    float dir;

    public float moveSpeed = 10f;
    public float num = 3f;
    public float outside1 = 2.5f;
    public float downSpeed = 3f;
    public float turnDistance = 0.2f;
    public float destroyY = -5f;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        startPos = transform.position;

        ChangeDirection();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= num)
        {
            ChangeDirection();
            timer = 0;
        }

        float distance = startPos.x + outside1 - rigid.position.x;
        float leftDistance = rigid.position.x - (startPos.x - outside1);

        if (distance < turnDistance && dir > 0)
            dir = -1;

        if (leftDistance < turnDistance && dir < 0)
            dir = 1;

        Vector2 pos = rigid.position;

        pos.x += dir * moveSpeed * Time.deltaTime;
        pos.y -= downSpeed * Time.deltaTime;

        rigid.MovePosition(pos);

        if (pos.y < destroyY)
        {
            Destroy(gameObject);
        }
    }

    void ChangeDirection()
    {
        dir = Random.Range(0, 2) == 0 ? -1 : 1;
    }
}
