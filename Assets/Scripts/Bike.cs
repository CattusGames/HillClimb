using UnityEngine;

public class Bike : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Wheel[] _wheels;
    [SerializeField] private float _rotation;
    [SerializeField] private Rigidbody2D _rb;

    public void OnGas()
    {
        SetTorque(-_speed);
    }

    public void OnBrake()
    {
        SetTorque(_speed);
    }

    private void SetTorque(float speed)
    {
        foreach(Wheel wheel in _wheels)
        {
            wheel.wheel.AddTorque(speed * wheel.speedMultiplier);
        }

        _rb.AddTorque(_rotation * speed);
    }
}

[System.Serializable]
public class Wheel
{
    public Rigidbody2D wheel;
    public float speedMultiplier;
}
