using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UEngine;
public class TestResourceManager : MonoBehaviour {

    public ResourceManager m_resMgr = null;
	// Use this for initialization
	void Start () 
    {
        Debug.Log("Start");
        m_resMgr = ResourceManager.GetInstance();
        m_resMgr.Init();
        //TestLoadIcon();
        //TestLoadCube1();
        TestLoadTwoCube();
        TestLoadSprite();
        TestLoadTexture2D();
        TestLoadCube5();
        
       
        

	}

    void TestLoadTwoCube()
    {
        GameObject cubeGo = m_resMgr.GetPrefab("Prefabs/TwoCube");
        //m_resMgr.PrintBundleCache(1);
        //m_resMgr.ReleasePrefab(cubeGo);
        //m_resMgr.PrintBundleCache(2);
    }
    void TestLoadSprite()
    {
        Sprite sprite = m_resMgr.GetSprite("Atlas/Test/icon_attack2");
        Image imgCom = gameObject.GetComponent<Image>();
        imgCom.sprite = sprite;
    }

    void TestLoadTexture2D()
    {
        Texture2D texture = m_resMgr.GetTexture2D("Textures/S_1");
        //Image imgCom = gameObject.GetComponent<Image>();
        //imgCom.sprite = (Sprite)texture;
        return;
    }

    void TestLoadCube5()
    {
        GameObject cubeGo = m_resMgr.GetPrefab("Cube_5");

    }
	
}
