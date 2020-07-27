using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    // 魔法力
    private int mp = 53;         

    // 魔法用の関数
    public void Magic(int mppoint)
    {

        //現在のmpが消費mp以上の場合
        if (mp>=mppoint)
        {
            //mp消費
            this.mp -= mppoint;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        //現在のmpが消費mp以下の場合
        else
        {
            Debug.Log("MPが足りない");
        }
        
    }
   

}

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //要素数５の配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        //配列の要素を順番に表示する
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素を逆に表示する
        for (int i = array.Length - 1; i >= 0; i--)
        {
            
            Debug.Log(array[i]);
        }





        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 魔法用の関数を呼び出す
        
       for(int i = 0; i <11; i++)
        {
            lastboss.Magic(5);
            
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


