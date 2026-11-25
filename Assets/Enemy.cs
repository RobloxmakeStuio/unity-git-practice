using UnityEngine;
public class Enemy : MonoBehaviour
{ 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    float health = 50.0f;
    public float speed;
    public float Health
    {
        get { return health; }
        set { health = value; }
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
            collision.gameObject.SetActive(false);
        }

    }
}
