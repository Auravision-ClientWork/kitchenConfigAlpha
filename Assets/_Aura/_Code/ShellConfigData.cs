using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellConfigData : MonoBehaviour
{
    //data
    [SerializeField] Material[] cabinetMaterials;
    [SerializeField] MeshRenderer[] cabinets;

    private void Start()
    {
        foreach(var cab in cabinets)
        {
            cab.material = cabinetMaterials[0];
        }
    }

    public void SwitchCabMaterial(int _matIndex)
    {
        foreach (var cab in cabinets)
        {
            cab.material = cabinetMaterials[_matIndex];
        }
    }
}
