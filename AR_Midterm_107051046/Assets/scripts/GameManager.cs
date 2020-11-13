
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("zero1")]
    public Transform zero1;
    [Header("zero2")]
    public Transform zero2;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    [Header("zero1動畫元件")]
    public Animator anizero1;
    [Header("zero2動畫元件")]
    public Animator anizero2;



    private void Start()
    {
        print("開始事件執行中");
       
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        zero1.Rotate(0, -joystick.Horizontal * turn, 0);
        zero2.Rotate(0, -joystick.Horizontal * turn, 0);
        zero1.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        zero2.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
    }
       public void PlayAnimation(string aniName)
        {
            print(aniName);
            anizero1.SetTrigger(aniName);
            anizero2.SetTrigger(aniName);
        }
    
  
}