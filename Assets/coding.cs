using UnityEngine;
using UnityEngine.Rendering;

public class coding : MonoBehaviour
{
    void Start() // 초기화 할때 유용. 프라프티 속성.
    {
        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);

        //Debug.Log(john.age);
        //lisa.Sleep();
        Adult maria = new Adult("maria", 10, 12);
        maria.Age = 1;
        maria.SetBaseAge(2);
        //Debug.Log(maria.Age);
        //Debug.Log(maria.GetBaseAge());

        Human Paul = new Human("paul", 3, 90);
        Baby baby = Paul as Baby;

        if (baby == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }
        Human Alexis = new Adult("alexis", 23, 155);
        Adult adult_alexis = Alexis as Adult;
        if (adult_alexis == null)
        {
            Debug.Log("형변환 실패");
        }
        else
        {
            Debug.Log("형변환 성공");
        }

        Bird eagle = new Bird();
        Fish shark = new Fish();
        eagle.Move();
        shark.Move();
    }
}

class Knight:ISword,IShield
{
    public string Damage { get; set; }
    public string DefensivePower { get; set; }

    public void Attack() { }
    public void Defend() { }
}

interface ISword
{
    public string Damage { get; set; }
    public void Attack();
}
interface IShield
{
    public string DefensivePower { get; set; }
    public void Defend();
}

abstract class Animal
{
    public abstract void Move();

    public void Eat()
    {
        Debug.Log("eat");
    }
}
class Bird : Animal
{
    public override void Move()
    {
        Debug.Log("fly");
    }
}
class Fish : Animal
{
    public override void Move()
    {
        Debug.Log("swim");
    }
}

class Adult : Human
{
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }

    public new void PrintAddress()//new?
    {
        Debug.Log(address);
    }
    public new int Age;//new 하면 에러 사라짐.
    public void SetBaseAge(int age)
    {
        base.age = age;
    }
    public int GetBaseAge()
    {
        return base.age;
    }
}

class Baby : Human
{
    public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
}
class Human
{
    public string name = "name";
    public float height = 165f;
    public int age = 21;
    protected string address;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public float Height
    {
        get { return height; }
        set { height = value; }
    }

    public int GetAge()
    {
        return age;
    }
    public void SetAge(int _age)
    {
        age = _age;
    }
    public Human()
    {

    }
    public Human(string _name, int _age, float _height)
    {
        name = _name;
        age = _age;
        height = _height;
    }

    public void Eat()
    {
        Debug.Log("eat");
    }
    public virtual void Walk()
    {
        Debug.Log("walk");
    }
    public void Sleep()
    {
        Debug.Log("sleep");
    }
    public void PrintAddress()
    {
        Debug.Log(address);
    }
}
