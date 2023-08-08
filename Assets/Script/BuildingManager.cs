using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    private BuildingTypeSO buidingType;
    private BuildingTypeListSO BuildingTypeList;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        BuildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
        buidingType = BuildingTypeList.list[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(buidingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            buidingType = BuildingTypeList.list[0];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            buidingType = BuildingTypeList.list[1];
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            buidingType = BuildingTypeList.list[2];
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
    }
}
