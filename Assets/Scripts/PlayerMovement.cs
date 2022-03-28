using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerSpeed;
    [SerializeField] private float _speedChangingValue;

    [SerializeField] private float _playerMovingSpeed;

    private Rigidbody rb;
    private Vector3 _playerMovementInput;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (_playerSpeed <= 10)
        {
            _playerSpeed += _speedChangingValue;
        }

        _playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        PlayerMovementControl();
    }

    private void PlayerMovementControl()
    {
        Vector3 MoveVector = transform.TransformDirection(_playerMovementInput) * _playerMovingSpeed;
        rb.velocity = new Vector3(MoveVector.x, rb.velocity.y, MoveVector.z);
    }
}


