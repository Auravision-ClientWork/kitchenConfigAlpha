using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfConfigData : ConfigManager
{
   private Dictionary< MeshRenderer, List<Material>> matData = 
        new Dictionary<MeshRenderer,List<Material>>();
    protected override void Start()
    {
        foreach (var renderer in m_TargetObjects)
        {
            //    List<Material> mat = new List<Material>();
            //    renderer.GetMaterials(mat);
            //    matData.Add(renderer, mat);
            renderer.material = m_Materials[0];
        }
      
        //foreach(KeyValuePair<MeshRenderer, List<Material>> pair in matData)
        //{
        //    pair.Key.ma = m_Materials[0];

        //}

    }
}
