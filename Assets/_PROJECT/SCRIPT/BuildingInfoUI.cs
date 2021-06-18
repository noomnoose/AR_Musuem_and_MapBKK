using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoUI : MonoBehaviour
{
    public Image image;
    public Text header;
    public Text description;

    void Start()
    {

    }

    public void Open(BuildingInfo info)
    {
        image.sprite = Sprite.Create(info.image, new Rect(0, 0, info.image.width, info.image.height), new Vector2(0.5f, 0.5f));
        header.text = info.header;
        description.text = info.description;
        
        gameObject.SetActive(true);
    }

}
