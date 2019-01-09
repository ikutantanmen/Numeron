using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    // Use this for initialization
    void Start () {
        //初期化
        Formula.text = "";
        Answer.text = "";
    }

    // Update is called once per frame
    void Update () {

    }

    // 数字ボタン押下
    public void InputNumber(Text number){
        // 押下したボタンの数字を式欄に追記する
        Formula.text += number.text; 
    }

    // Callボタン押下
    public void InputEqual(Text equal){

    }

    // クリアボタン押下
    public void InputClear(Text equal){
        //初期化
        Formula.text = "";
        Answer.text = "";        
    }
}
