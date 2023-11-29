using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            transform.Translate(new Vector3(0, jumpForce, 0) * moveSpeed * Time.deltaTime);
        }
    }
}
