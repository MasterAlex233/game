using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour
{
    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;

    private void Awake()
    {
        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();
        ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name)
        foreach (ResourcesTypeSO resourcesType in resourceTypeList.list)
        {
            resourceAmountDictionary[resourcesType] = 0
        }
    }
}
