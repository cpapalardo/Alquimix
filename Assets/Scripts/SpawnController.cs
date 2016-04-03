using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

    public GameObject wingPrefab;
    public GameObject eyePrefab;
    public GameObject legPrefab;
    public GameObject tentaclePrefab;

    public GameObject auxObject;

    private float timer = 0f;
    private float interval = 5f;
    private int ingredientId = 0;

	// Use this for initialization
	void Start () {
        timer = Random.Range(interval - 1.0f, interval + 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        Spawner();
	}

    public void Spawner()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            SpawnIngredient();

            timer = Random.Range(0f, 1f);
            interval = 5f;

            interval = Random.Range((interval - (interval * 0.2f)), (interval + (interval * 0.2f)));
        }
    }

    public void SpawnIngredient()
    {
        ingredientId = Random.Range(1, 4);

        switch (ingredientId)
        {
            case 1:
                auxObject = Instantiate(eyePrefab, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)))) as GameObject;
                break;
            case 2:
                auxObject = Instantiate(tentaclePrefab, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)))) as GameObject;
                break;
            case 3:
                auxObject = Instantiate(legPrefab, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)))) as GameObject;
                break;
            case 4:
                auxObject = Instantiate(wingPrefab, gameObject.transform.position, Quaternion.Euler(new Vector3(0, 0, Random.Range(0, 360)))) as GameObject;
                break;
            default:
                Debug.Log("Ingrediente não capturado.");
                break;

        }


    }

}
