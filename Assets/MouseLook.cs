using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody; //Riferimento al player
    float xRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked; //Cursore bloccato al centro dello schermo  
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;  //Valore di rotazione dall'input manager per la visibilità del mouse (sensibilità modificabile)

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90); //limitare i valori tra
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
