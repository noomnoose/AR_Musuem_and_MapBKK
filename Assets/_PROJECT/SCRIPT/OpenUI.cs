using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ASPageView;

public class OpenUI : MonoBehaviour
{
    public static GameObject current;
    //public GameObject ui;
    public string file;
    public Transform root;

    public void OnClick()
    {
        if (current)
        {
            GameObject.Destroy(current);
        }

        var prefab = Resources.Load<GameObject>(file);
        var go = GameObject.Instantiate<GameObject>(prefab);
        go.transform.SetParent(root, false);
        go.SetActive(true);
        go.GetComponent<PageView>().SetCurrentPage(0);
        current = go;
        // ui.SetActive(true);
        // Debug.Log("Clicked");
    }

}






//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class OpenUI : MonoBehaviour
//{
//    public GameObject ui;

//public void OnClick()
//    {
//        ui.SetActive(true);
//        Debug.Log("Clicked");
//    }

//}
