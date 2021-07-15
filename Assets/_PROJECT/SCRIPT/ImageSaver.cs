using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ImageSaver : MonoBehaviour
{
    public void SaveTexture(Texture2D texture)
    {
        byte[] bytes = texture.EncodeToPNG();
        var dirPath = Application.dataPath + "/Download";
        if (!System.IO.Directory.Exists(dirPath))
        {
            System.IO.Directory.CreateDirectory(dirPath);
        }
        System.IO.File.WriteAllBytes(dirPath + "/R_" + UnityEngine.Random.Range(0, 100000) + ".png", bytes);
        Debug.Log(bytes.Length / 1024 + "Kb was saved as: " + dirPath);
#if UNITY_EDITOR
        UnityEditor.AssetDatabase.Refresh();
#endif
    }

    public void DownloadImage(Texture2D texture)
    {
        byte[] bytes = texture.EncodeToPNG();

        NativeGallery.Permission permission = NativeGallery.SaveImageToGallery
            ( bytes, "GalleryTest", "Image.png", ( success, path ) => Debug.Log( "Media save result: " + success + " " + path ) );
    }
}
