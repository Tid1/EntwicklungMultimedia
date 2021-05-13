using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCoins : MonoBehaviour {
    public Transform myPrefab;
    public float range;
    public int numberOfCoins;
    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i < numberOfCoins; ++i)
        {
            float xCoord = Random.Range(-range, range);
            float zCoord = Random.Range(-range, range);
            Instantiate(myPrefab, new Vector3(xCoord, 1, zCoord), myPrefab.rotation, this.transform);
        }
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
