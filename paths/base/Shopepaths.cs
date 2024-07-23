using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewShopParts")] 
// 특정 스크립트에서 새로운 어셋을 생성할 수 있는 메뉴 옵션을 제공
//fileName : 생성되는 에셋의 이름을 결정합니다.
//menuName : 에셋을 생성하는 메뉴의 이름을 정할 수 있습니다.  "/" 를 넣으면 경로가 추가됩니다.
public class Shopaths : ScriptableObject, IPartsBuy  // ScriptableObject, IPartsBuy클래스 상속 받음
                        //Scriptable Object는 유니티에서 제공하는 대량의 데이터를 저장하는 데 사용할 수 있는 데이터 컨테이너
{
    public int Price; 
    public Parts Part; 

    public bool buy(int val) //bool : 논리값을 담는 자료형
    {
        if(Price < val)
        {
            return true; 
        }
        return false;
    }


}
