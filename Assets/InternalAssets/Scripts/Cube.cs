using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Color _color;
    private MaterialPropertyBlock _propBlock;

    private void Start()
    {
        _propBlock = new MaterialPropertyBlock();
        var renderer = GetComponent<Renderer>();

        renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor("_BaseColor", _color);
        renderer.SetPropertyBlock(_propBlock);
    }
}
