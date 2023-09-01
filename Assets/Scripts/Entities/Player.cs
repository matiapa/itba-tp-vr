using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {
    [SerializeField] private int _moveSpeed;
    [SerializeField] private AudioClip _crashSound;

    private AudioSource _audioSource;

    void Start() {
        _audioSource = GetComponent<AudioSource>();
    }

    void Update() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * _moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }

    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        _audioSource.PlayOneShot(_crashSound);
    }
}
