using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed;

    public void Initialize(Target target)
    {
        _speed = 0.5f;
        _target = target;
    }

    private void Update()
    {
        if (_target != null) 
        {
            Chase();
        }
    }

    private void Chase()
    {
        transform.position = Vector3.Lerp(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }
}
