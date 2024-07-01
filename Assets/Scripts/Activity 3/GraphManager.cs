using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphManager : MonoBehaviour
{
    public event Action OnMouseClick;

    [Header("Graph")]
    public Graph currentGraph;
    [Header("Layer Mask")]
    [SerializeField] private LayerMask placementLayerMask;

    private Vector3 lastMousePosition;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
        {
            OnMouseClick?.Invoke();
        }
	}

	public Vector3 GetSelectedMapPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = currentGraph.interactiveGraphCamera.nearClipPlane;
        RaycastHit hit;
        Ray ray = currentGraph.interactiveGraphCamera.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out hit, 100, placementLayerMask))
        {
            lastMousePosition = hit.point;
        }
        return lastMousePosition;
    }
}