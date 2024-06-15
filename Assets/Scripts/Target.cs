using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform _routePoint;
    
    private Vector3 _originPoint;
    private Vector3 _destination;

    private int _speed;

    private void Awake()
    {
        _originPoint = transform.position;
        _destination = _routePoint.position;
        _speed = 2;
    }

    void Update()
    {
        if (transform.position == _routePoint.position)
        {
            _destination = _originPoint;
        }

        if (transform.position == _originPoint)
        {
            _destination = _routePoint.position;
        }

        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _destination, _speed * Time.deltaTime);
    }
}
