using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    入力ラッパ：
    VRChatが想定するあらゆる入力デバイスからの入力を管制して共通の入力要素に変換するラッパークラス
    たぶんハードウェアごとにインナークラスを作ったほうが良い
    対応優先度：
    ・Valve Index
    ・HTC Vive ワンドコントローラ
    ・キーボード&マウス
    ・Oculus Touch + Quest コントローラー
    -- (圧倒的優先度の壁) --
    ・ゲームパッド
    ・Vive Cosmosその他
    */
    public class InputWrapper : UdonSharpBehaviour
    {
        void Start()
        {
            
        } 
    }
}