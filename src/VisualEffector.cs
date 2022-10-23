using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    視覚エフェクタ：
    ほぼ全てのコンポーネントを参照・管理し、ウィングレットに関連する適切なイベントを発火する機能を持つ、
    コンポーネント利用者（ワールド作成者）側で特定のパーティクルを再生させたいときなどに、
    本クラスが発火したイベントを使ってもらう。
    */
    public class VisualEffector : UdonSharpBehaviour
    {
        void Start()
        {
            
        }
    }
}