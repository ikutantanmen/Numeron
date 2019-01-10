using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

    // 式入力テキスト
    public Text Formula;
    // 結果表示テキスト
    public Text Answer;
    // 各数字ボタン
    public Button[] bNumber;
    // Callボタン
    public Button bEqual;
    // クリアボタン
    public Button bClear;
    //答えとなる3桁の数字（x…百の位、y…十の位、z…一の位）
    int x, y, z;
    //プレイヤーが入力した3桁の数字（a…百の位、b…十の位、c…一の位）
    int a = 0, b = 0, c = 0;
    //eatの数、biteの数を表示する変数
    int e_count, b_count;

    // Use this for initialization
    void Start () {
        //初期化
        Formula.text = "";
        Answer.text = "";

        //答えの数字3桁をランダムに生成（同じ数字が2回以上でないようにする）
        x = Random.Range(1, 10);
        do
        {
            y = Random.Range(1, 10);
        } while (y == x);
        do
        {
            z = Random.Range(1, 10);
        } while (z == x || z == y);
    }

    // Update is called once per frame
    void Update () {

    }

    // 数字ボタン押下
    public void InputNumber(Text number){
        // 押下したボタンの数字を式欄に追記する
        Formula.text += number.text;
        if (a == 0)
        {
            a = int.Parse(number.text);
        } else if (b == 0 && int.Parse(number.text)!= a)
        {
            b = int.Parse(number.text);
        } else if (c == 0 && int.Parse(number.text) != b)
        {
            c = int.Parse(number.text);
        }
    }


    // Callボタン押下
    public void InputEqual(Text equal) {
        //eatの数を測定
        e_count = 0;
        if (a == x)
        {
            e_count++;
        }
        if (b == y)
        {
            e_count++;
        }
        if (c == z)
        {
            e_count++;
        }
        //biteの数を測定
        b_count = 0;
        if (a == y || a == z)
        {
            b_count++;
        }
        if (b == x || b == z)
        {
            b_count++;
        }
        if (c == x || c == y)
        {
            b_count++;
        }
        if (e_count == 3)
        {
            Answer.text = "Hit!";
        } else
        {
            Answer.text = e_count + "eat " + b_count + "bite" + "\r\n"
                + "あなたの数字：" + a + "" + b + "" + c + "\r\n"
                + "答え：" + x + "" + y + "" + z;
            //再度初期化
            Formula.text = "";
            a = 0;
            b = 0;
            c = 0;
        }
    }

    // クリアボタン押下
    public void InputClear(Text equal){
        //初期化
        Formula.text = "";
        Answer.text = "";
        a = 0;
        b = 0;
        c = 0;
    }
}