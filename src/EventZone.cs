using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace ArkWinglet
{
    /*
    イベントゾーン：
    本スクリプトがアタッチされたオブジェクトにTrigger接触・滞在・離脱したプレイヤーに対し、
    規定のアクションを強制的に実行する機能を持つ
    アクション一覧（暫定。たぶん増える）
    ・有効化/無効化
    ・ウィング展開/格納

    イベントには下記２つの設定を調整できる
    ・トリガー条件（Enter, Stay, Leave）
    ・フィルター条件（inNames, inTags, ウィングレットに限らないタグ付きGameObject？）
    
    カスタムアクションの登録も受け付けるようにする
    これにより、コンポーネント利用者（ワールド作成者）がウィングレットを使ったゲームコンテンツの作成を支援する。
    */
    public class EventZone : UdonSharpBehaviour
    {
        void Start()
        {
            
        }
    }
}