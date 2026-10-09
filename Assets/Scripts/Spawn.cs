using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject objetosParaSpawn;
    private Vector3 spawnPosition=new Vector3(-58.26f, 15.6f, 84.77f);

    public float StartDelay = 2f;
    public float repeatRate = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SwpawnObstaculo", StartDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwpawnObstaculo()
    {
        Instantiate(objetosParaSpawn, spawnPosition, objetosParaSpawn.transform.rotation);
    }
}
