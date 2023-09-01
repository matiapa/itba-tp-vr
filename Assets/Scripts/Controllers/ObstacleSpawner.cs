using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    [SerializeField] private int _frequency;
    [SerializeField] private GameObject _obstacle;
    [SerializeField] private int _spawnDistance;
    [SerializeField] private int _roadDistance;

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
        GameObject player = GameObject.FindWithTag("Player");

        Vector3 position = player.transform.position + _spawnDistance * Vector3.forward + _roadDistance * Vector3.left;
        position.y = 0;

        Quaternion rotation = Quaternion.LookRotation(Vector3.right);

        Instantiate(_obstacle, position, rotation);
    }

}
