using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements.Experimental;// 키워드 using 모듈을 포함한다.

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // public private 접근지정자 아무것도 안하면 기본적으로 private
    //public 외부 공용, private 비공개 아무것도 없는 것도 비공개.

    int[] scores = new int[5];

    void Start()
    {
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = (i+1)*10;//i*10
        }

        Debug.Log(scores[0]);
        Debug.Log(scores[1]);
        Debug.Log(scores[2]);
        Debug.Log(scores[3]);
        Debug.Log(scores[4]);
    }
    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");//수평 좌우
        float y = Input.GetAxisRaw("Vertical");//상하 위아래

        Vector3 direction = new Vector3(x, y, 0);//벡터화
        transform.position += direction.normalized * speed * Time.deltaTime;//normalized (1,1,0)이면 대각선 1.2정도 인걸 평준화 1로 조정 한다.. deltatime 프레임이 느리거나 빠르게나 모두 똑같이 되게 잡아줌.
    }
}
