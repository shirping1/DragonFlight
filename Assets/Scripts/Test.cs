using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //배열
    //ArrayList arrayList = new ArrayList();

    //List<string> list = new List<string>();

    List<GameObject> list = new List<GameObject>();

    

    void Start()
    {
        //arrayList.Add(1);
        //arrayList.Add(2);
        //arrayList.Add(3);
        //arrayList.Add("가나다라");
        //arrayList.Add(4.5f);

        //arrayList[4] = 5;

        //for (int i = 0; i < arrayList.Count; i++)
        //{
        //    Debug.Log(arrayList[i]);
        //}

        //list.Add("안녕하세요");
        //list.Add("필살기!!");

        Debug.Log(list[0]);
        Debug.Log(list[1]);

    }

    void Update()
    {
        
    }
}
