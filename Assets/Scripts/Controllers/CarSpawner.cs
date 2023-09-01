using UnityEngine;

public class CarSpawner : MonoBehaviour {
    [SerializeField] private int _frequency;
    [SerializeField] private GameObject _car;

    private float _countdown;

    void Start () {
        _countdown = _frequency;
    }

    void Update () {
        if (_countdown <= 0f) {
            SpawnObstacle();
            _countdown = _frequency;
            return;
        }

        _countdown -= Time.deltaTime;   
    }    
    
    void SpawnObstacle () {
        Quaternion rotation = Quaternion.LookRotation(Vector3.right);

        Instantiate(_car, gameObject.transform.position, rotation);
    }

}
