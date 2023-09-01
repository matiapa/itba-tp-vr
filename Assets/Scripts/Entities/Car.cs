using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour {

    [SerializeField] private int _speed;
    [SerializeField] private float _lifetime;

    void Update() {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        
        _lifetime -= Time.deltaTime;

        if (_lifetime <= 0) {
            Destroy(gameObject);
        }
    }

}