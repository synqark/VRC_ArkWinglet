using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    ロガー：
    ウィングレットのすべてのコンポーネントから参照され、それぞれがログとして出力した情報を整形し、
    適切なインターフェスに出力するパイプクラス
    
    プロパティから指定されたTextコンポーネントを持つGameObjectとか、
    VRChatのデバッグログとかに出す。たぶん。
    */
    public class Logger : UdonSharpBehaviour
    {
        void Start()
        {
            
        }
    }
}