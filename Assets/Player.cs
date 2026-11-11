using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100f;

    void Start()
    {

    }

    void Update()
    {

    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(20);
        Destroy(collision.gameObject);
    }

    private void TakeDamage(int vlaue)//´ÙÇü¼º
    {
        health -= vlaue;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Player Health : " + health);
    }

}