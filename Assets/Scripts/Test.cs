using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //�迭
    //ArrayList arrayList = new ArrayList();

    //List<string> list = new List<string>();

    List<GameObject> list = new List<GameObject>();

    

    void Start()
    {
        //arrayList.Add(1);
        //arrayList.Add(2);
        //arrayList.Add(3);
        //arrayList.Add("�����ٶ�");
        //arrayList.Add(4.5f);

        //arrayList[4] = 5;

        //for (int i = 0; i < arrayList.Count; i++)
        //{
        //    Debug.Log(arrayList[i]);
        //}

        //list.Add("�ȳ��ϼ���");
        //list.Add("�ʻ��!!");

        Debug.Log(list[0]);
        Debug.Log(list[1]);

    }

    void Update()
    {
        
    }
}
