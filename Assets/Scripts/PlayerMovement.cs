using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerMovingSpeed;
    [SerializeField] private float _upMovingSpeed;
    [SerializeField] private float _rotationSpeed;
        
    private Rigidbody _rbPlayer;
    private Vector3 _playerMovementInput;
    private Vector3 MoveVector;
    
    private void Start()
    {
        _rbPlayer = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MoveVector = transform.TransformDirection(_playerMovementInput) * _playerMovingSpeed;
        PlayerMovementControl();
        if (Input.GetKey(KeyCode.E) && gameObject.transform.localPosition.z <= 5f)
        {
            BallonAddHeight();
        }

        if (Input.GetKey(KeyCode.Z))
        {
            BaloonRotation();
        }
    }

    private void PlayerMovementControl()
    {
        _rbPlayer.velocity = new Vector3(MoveVector.x, _rbPlayer.velocity.y, MoveVector.z);
    }

    private void BallonAddHeight()
    {
        _rbPlayer.velocity = new Vector3(MoveVector.x, _upMovingSpeed, MoveVector.z);
    }

    private void BaloonRotation()
    {
        _rbPlayer.AddRelativeTorque(_rotationSpeed,0f,0f);
    }
}


