using UnityEngine;

public class ParallaxBehaviour : MonoBehaviour
{
    [SerializeField] private Transform _followTarget = null;
    [SerializeField, Range(0f, 1f)] private float _parallaxStrength = 0.1f;
    [SerializeField] private bool _disableVerticalParallax;

    private Vector3 _targetPreviousPosition;

    void Start()
    {
        if (!_followTarget)
            _followTarget = Camera.main.transform;

        _targetPreviousPosition = _followTarget.position;
    }

    void Update()
    {
        var deltaPosition = _followTarget.position - _targetPreviousPosition;

        if (_disableVerticalParallax)
            deltaPosition.y = 0;

        _targetPreviousPosition = _followTarget.position;

        transform.position += deltaPosition * _parallaxStrength;
    }
}
