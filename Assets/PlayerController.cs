using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements.Experimental;// 키워드 using 모듈을 포함한다.

public class PlayerController : MonoBehaviour // 이미 만들어진 MonoBehaviour클래스를 상속 ":"이게 상속 뜻함. / 클래스:설계도면 비슷한 것 | 붕어빵 틀 클래스/ 붕어빵 먹는게 오브젝트
{
    public float speed = 0.01f;
    void Start()
    {
        //gameObject.SetActive(false); //박스모양:메소드는 ()하기 f/t하기. 뺀찌모양  스페너: 속성 값 = t/f 하기.
        /*bool a = true;
        bool b = false;
        gameObject.SetActive(a || b);*/
        transform.position =  Vector3.one; // (1, 1, 1)
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed, 0);//  translate: 특정한 좌표로 설정해라. this 자기 자신 객체
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed, 0);//  translate: 특정한 좌표로 설정해라.
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);//  translate: 특정한 좌표로 설정해라.
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);//  translate: 특정한 좌표로 설정해라.
        }

    }
}
