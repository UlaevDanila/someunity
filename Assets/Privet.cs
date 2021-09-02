using UnityEngine;

public class Privet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _playerBody;

    private void Start()
    {
        _playerBody = GetComponent<Rigidbody>();    
    }

    private void Update()
    {
        var input = Input.GetAxis("Horizontall");

        Debug.Log(input);

        var direction = new Vector3(0f, 0f, input);
        _playerBody.velocity = direction * input;
    }
}
