//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;

////Object缓存，当删除资源时，需要把对应的obj设置成null，否则Unloadunuse不会释放他
//public class ObjectCache
//{
//    private Dictionary<string, Object> m_cache = new Dictionary<string, Object>();
//    public void AddObject(string assetName, Object obj)
//    {
//        Object objInCache = null;
//        if (!m_cache.TryGetValue(assetName, out objInCache))
//        {
//            m_cache.Add(assetName, obj);
//        }
//    }

//    public void RemoveObject(string assetName)
//    {
//        Object objInCache = null;
//        if (m_cache.TryGetValue(assetName, out objInCache))
//        {
//            objInCache = null;
//            m_cache.Remove(assetName);
//        }

//    }

//    public void Print()
//    {
//        foreach(KeyValuePair<string, Object> kv in m_cache)
//        {
//            Debug.Log("ObjectCache: " + kv.Key);
//        }
//    }

//}
