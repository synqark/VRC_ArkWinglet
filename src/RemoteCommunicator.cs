using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    リモート通信コンポーネント：
    以下の機能を持つ：
    ・コアローカル監視し、必要に応じてリモートプレイヤーに情報を伝達する
    ・リモートプレイヤーから受け取った情報をもとに、各コアリモートに情報を伝達する
    */
    public class RemoteCommunicator : UdonSharpBehaviour
    {
        void Start()
        {
            
        }
    }
}