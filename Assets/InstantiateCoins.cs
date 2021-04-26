using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCoins : MonoBehaviour {
    public Transform myPrefab;

    // Start is called before the first frame update
    void Start() {
        for(int i = 0; i <= 10; ++i)
        {
            float xCoord = Random.Range(-25f, 25f);
            float zCoord = Random.Range(-25f, 25f);
            Instantiate(myPrefab, new Vector3(xCoord, 1, zCoord), myPrefab.rotation, this.transform);
        }
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
