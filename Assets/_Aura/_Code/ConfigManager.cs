using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ConfigManager : MonoBehaviour
{
    [SerializeField] protected Material[] m_Materials;
    [SerializeField] protected MeshRenderer[] m_TargetObjects;
    protected virtual void Start()
    {
        
        foreach (var cab in m_TargetObjects)
        {
            cab.material = m_Materials[0];
        }
    }

    public virtual void SwitchTargetObjectMaterial(int _matIndex)
    {
        FindObjectOfType<AudioManager>().PlayMatButtonFx();
            
        foreach (var cab in m_TargetObjects)
        {
            
            
            cab.material = m_Materials[_matIndex];
        }
    }
}
