using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadSpriteFromResources : MonoBehaviour {
    public string spriteName;
    
    static AssetBundle assetbundle = null;
    private static AssetBundleManifest m_manifest = null;
    private static AssetBundle m_manifestAB = null;
    void Start()
    {
        GetManifest();
        TestDependency();
        Image imgCom = transform.GetComponent<Image>();
        //imgCom.sprite = LoadSprite("vs");
        imgCom.sprite = LoadSprite(spriteName, true);
    }

    private Sprite LoadSprite(string spriteName, bool isFromAB)
    {
        if (isFromAB)
        {
            if (assetbundle == null)
            {
                Debug.Log("assetbundle == null");
                assetbundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/Test.assetbundle");
                //assetbundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/test");
            }
            //Sprite sprite = assetbundle.LoadAsset(spriteName) as Sprite;
            //return sprite;
            Sprite sprite = assetbundle.LoadAsset<Sprite>(spriteName);
            return sprite;
        }
        else
        {
            return Resources.Load<GameObject>("Sprite/" + spriteName).GetComponent<SpriteRenderer>().sprite;
        }  
    }

    AssetBundleManifest GetManifest()
    {
        AssetBundleManifest result = m_manifest;
        if (result == null)
        {
            if (m_manifestAB == null)
            {
                m_manifestAB = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/StreamingAssets");
                if (m_manifestAB == null)
                {
                    Debug.Log("m_manifestAB == null");
                }
            }
            result = m_manifestAB.LoadAsset<AssetBundleManifest> ("AssetBundleManifest");
        }

        return result;
    }

    void TestDependency()
    {
        AssetBundleManifest manifest = GetManifest();
        var dependencies = manifest.GetAllDependencies("uiprefabs.assetbundle");
        foreach(var dependency in dependencies)
        {
            Debug.Log("uiprefabs.assetbundle depenent :" + dependency);
        }
    }


}
