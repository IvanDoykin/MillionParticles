using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDynamicUV : MonoBehaviour
{
    [SerializeField] private Vector2Int _subtextureIndex;
    private Material _material;

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        _material.SetVector("_BaseMap_ST", new Vector4(1f / 6f, 1f / 4f, _subtextureIndex.x / 6f, _subtextureIndex.y / 4f));
    }
}
