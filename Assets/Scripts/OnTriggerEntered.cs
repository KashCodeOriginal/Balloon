using UnityEngine;

public class OnTriggerEntered : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    private void OnTriggerEnter(Collider _collider)
    {
        if (_collider.name == "Height6")
        {
            _playerMovement._allowedBallonHeight = 6f;
        }
        if (_collider.name == "Height7")
        {
            _playerMovement._allowedBallonHeight = 7f;
        }
        if (_collider.name == "Height9")
        {
            _playerMovement._allowedBallonHeight = 9f;
        }
        if (_collider.name == "Height11")
        {
            _playerMovement._allowedBallonHeight = 11f;
        }
        if (_collider.name == "Height12")
        {
            _playerMovement._allowedBallonHeight = 12f;
        }
        
    }
}
