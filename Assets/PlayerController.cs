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
            GameObject Bullet = Instantiate(BulletPrefab); // 실제로 실제화 하는 것 인스턴스 생성.
            Bullet.transform.position = transform.position; // 총알 위치 우주선 플레이어 위치로
            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed); // add force 힘 추가해라.
        }
    }
}
