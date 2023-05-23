using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float _speed = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * _speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
    }
}
