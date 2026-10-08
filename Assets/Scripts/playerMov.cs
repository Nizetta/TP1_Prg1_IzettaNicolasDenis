using UnityEngine;

public class playerMov : MonoBehaviour
{

    [SerializeField] private float velocidad = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        float upDown = Input.GetAxis("Jump");

        Vector3 movimiento = new Vector3(movimientoHorizontal, upDown, movimientoVertical);

        transform.Translate(movimiento * velocidad * Time.deltaTime);
        
    }
}
