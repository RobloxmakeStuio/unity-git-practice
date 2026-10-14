using UnityEngine;

public class coding : MonoBehaviour
{
    void Start() // 초기화 할때 유용. 프라프티 속성.
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach(int item in numbers)
        {
            Debug.Log(item);
        }

        int j = 1;
        while (true)
        {
            if (j > 5)
            {
                break;
            }
            Debug.Log(j);
            j++;
        }

        int k = 1;
        while (k <= 10)
        {
            if (k % 2 == 0)
            {
                k++;
                continue;
            }
            Debug.Log(k);
            k++;
        }

    }

    void Update()
    {
        
    }
}
class Human
{
    public string name = "name";
    public float height = 165f;
    public int age = 21;
}
