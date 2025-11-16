using UnityEngine;

public class MovimientoAuto : MonoBehaviour
{
   
    public float velocidad_de_movimiento;
    private float eje_z;

    private Rigidbody fisicas;

    private Vector3 posicion_inicial;
    private int healthpotion;
    private int maxpotions = 5;

    void Start()
    {
        posicion_inicial = transform.position;
        fisicas = GetComponent<Rigidbody>();
    }

    void Update()
    {
        eje_z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        fisicas.AddForce(eje_z * velocidad_de_movimiento * transform.forward);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("healthpotion") && healthpotion < maxpotions)
        {
            Destroy(collision.gameObject);
            healthpotion += 1;
            Debug.Log(healthpotion);
            
        }
        else
        {
            Debug.Log("maximo de pociones");
        }
    }

    private void VolverAlPrincipio()
    {
        transform.position = posicion_inicial;  
    }
}
