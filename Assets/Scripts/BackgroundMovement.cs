using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private MeshRenderer _meshRenderer;

    private Vector2 _meshOffset;
    
    private void OnDisable()
    {
        _meshRenderer.sharedMaterial.mainTextureOffset = _meshOffset;    
    }

    private void Start()
    {
        _meshOffset = _meshRenderer.sharedMaterial.mainTextureOffset;
    }

    private void Update()
    {
        var posX = Mathf.Repeat(Time.time * _speed, 1);
        var offset = new Vector2(posX, _meshOffset.y);

        _meshRenderer.sharedMaterial.mainTextureOffset = offset;
    }

}
