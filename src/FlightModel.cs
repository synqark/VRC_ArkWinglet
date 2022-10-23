using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    フライトモデル：
    文字通り、展開・飛行中の挙動計算を行う
    コアローカル・コアリモートそれぞれが持つクラスを想定しているが、共通部分があまりにも少なかったら
    このクラスはなかったことにしてそれぞれのコアクラスで挙動の計算を行う。
    （ただ、ローカル・リモートに限らずウィングレットの性能や挙動特性を示すパラメーターは同一にしたい...）
    */
    public class FlightModel : UdonSharpBehaviour
    {
        void Start()
        {
            
        }
    }
}