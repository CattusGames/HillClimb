using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _bike;
    [SerializeField] private float _followSpeed;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - _bike.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _bike.position + offset, _followSpeed);
    }
}
