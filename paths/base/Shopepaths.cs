using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewShopParts")] 
// Ư�� ��ũ��Ʈ���� ���ο� ����� ������ �� �ִ� �޴� �ɼ��� ����
//fileName : �����Ǵ� ������ �̸��� �����մϴ�.
//menuName : ������ �����ϴ� �޴��� �̸��� ���� �� �ֽ��ϴ�.  "/" �� ������ ��ΰ� �߰��˴ϴ�.
public class Shopaths : ScriptableObject, IPartsBuy  // ScriptableObject, IPartsBuyŬ���� ��� ����
                        //Scriptable Object�� ����Ƽ���� �����ϴ� �뷮�� �����͸� �����ϴ� �� ����� �� �ִ� ������ �����̳�
{
    public int Price; 
    public Parts Part; 

    public bool buy(int val) //bool : ������ ��� �ڷ���
    {
        if(Price < val)
        {
            return true; 
        }
        return false;
    }


}
