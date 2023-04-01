using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableObjects : MonoBehaviour
{
    public string objName;
    public GameObject animObjLeft;
    public GameObject animObjRight;
    public List<Transform> spawnPlaces;
    public bool alreadyPickedup;
    public InHandObject whatObjDo_L;
    public InHandObject whatObjDo_R;
    public int lastHand; // 1 - right, 0 left
    public bool placed;
    private IEnumerator spawner;

    public void PlaceObject()
    {
        placed = true;
        
        spawner = DespawnObjectCounter();
        StartCoroutine(spawner);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LightTrigger")
        {
            Debug.Log("SHIT");
            if (placed)
            {
                Debug.Log("SHIT");
                StopCoroutine(spawner);
            }
        }
    }

    IEnumerator DespawnObjectCounter()
    {
        yield return new WaitForSeconds(3f);
        DespawnObject();
    }

    private void DespawnObject()
    {
        gameObject.transform.position = spawnPlaces[Random.Range(0, spawnPlaces.Count)].position;
        placed = false;
        whatObjDo_L.ResetObject();
        whatObjDo_R.ResetObject();
        alreadyPickedup = false;
    }

}
