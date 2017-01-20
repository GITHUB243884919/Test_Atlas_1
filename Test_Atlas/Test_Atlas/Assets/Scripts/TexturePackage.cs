using UnityEngine;
//using UnityEditor;
using System.Collections;
using System.IO;


public class TexturePackage : MonoBehaviour
{
    public Texture2D[] texture;
    public Rect[] rects;

    void Start()
    {
        Texture2D altas = new Texture2D(2048, 2048);
        rects = altas.PackTextures(texture, 2, 2048);
        byte[] buffer = altas.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/mypackage.png", buffer);
        //AssetDatabase.Refresh();
    }
} 
