using UnityEngine;

public class camara : MonoBehaviour
{
    [SerializeField] private float sensibilidad = 100;
    public Transform Player;
    float RotacionHorizontal = 0;
    float RotacionVertical = 0;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        float ValorX=Input.GetAxis("Mouse X")*sensibilidad*Time.deltaTime;
        float ValorY=Input.GetAxis("Mouse Y")*sensibilidad*Time.deltaTime;
        RotacionHorizontal += ValorX;
        RotacionVertical -= ValorY;

        RotacionVertical = Mathf.Clamp(RotacionVertical, -90, 90);

        transform.localRotation = Quaternion.Euler(RotacionVertical, 0 ,0);

        Player.Rotate(Vector3.up * ValorX);

    }
}
