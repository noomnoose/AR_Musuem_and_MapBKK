using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEvent : MonoBehaviour
{
    public Transform building;
    public Vector3 position;
    public Vector3 scale;

    public static List<MapEvent> list;
    Renderer[] renders;
    Collider[] colliders;

    void Start()
    {
        var tracker = GetComponent<DefaultTrackableEventHandler>();
        tracker.OnTargetFound.AddListener(OnFound);
        tracker.OnTargetLost.AddListener(OnLost);

        renders = building.GetComponentsInChildren<Renderer>();
        colliders = building.GetComponentsInChildren<Collider>();

    }

    [ContextMenu("Copy")]
    void Copy()
    {
        var t = transform.GetChild(0);
        position = t.localPosition;
        scale = t.localScale;
    }

    void OnFound()
    {
        building.SetParent(transform, false);
        // building.localPosition = position;
        iTween.MoveTo(building.gameObject, iTween.Hash("position", position, "islocal", true, "time", 0.1f, "easetype", iTween.EaseType.linear));
        building.localScale = scale;

        if (list == null)
            list = new List<MapEvent>();

        if (list.Contains(this) == false)
            list.Add(this);

        CleanList();
        UpdateBuildingModel();
    }

    void OnLost()
    {
        if (list == null)
            list = new List<MapEvent>();

        if (list.Contains(this))
            list.Remove(this);

        CleanList();
        UpdateBuildingModel();

    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus == false)
        {
            list.Clear();
        }

        CleanList();
        UpdateBuildingModel();
    }

    void UpdateBuildingModel()
    {
        if (list.Count == 0)
        {
            // disable building
            building.SetParent(null);
            building.gameObject.SetActive(false);
        }
        else
        {
            foreach (var item in renders)
                item.enabled = true;
            
            foreach (var item in colliders)
                item.enabled = true;
            

            building.gameObject.SetActive(true);
        }
    }

    void CleanList()
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == null)
            {
                list.RemoveAt(i);
                i--;
            }
        }
    }

}
