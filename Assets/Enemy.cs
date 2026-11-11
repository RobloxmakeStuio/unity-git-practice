using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 100f;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void TakeDamage(int vlaue)//´ÙÇü¼º
    {
        health -= vlaue;
        if (health <= 0)
        {
            Die();
        }

        Debug.Log("Enemy Health : " + health);
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 
        {
            TakeDamage(10);
        }

    }
}
