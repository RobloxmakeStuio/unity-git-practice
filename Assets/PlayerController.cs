using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements.Experimental;// 키워드 using 모듈을 포함한다.

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject BulletPrefab;
    public float bulletSpeed = 100f;

    void Start()
    {
        
    }
    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");//수평 좌우
        float y = Input.GetAxisRaw("Vertical");//상하 위아래

        Vector3 direction = new Vector3(x, y, 0);//벡터화
        transform.position += direction.normalized * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i =0; i <3; i++)
            {
                GameObject Bullet = Instantiate(BulletPrefab);
                Vector3 bulletPos = transform.position;
                bulletPos.y += 0.3f * i;
                Bullet.transform.position = bulletPos;
                Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
            }
            
        }
    }
}
