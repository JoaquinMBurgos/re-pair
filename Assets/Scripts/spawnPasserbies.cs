using UnityEngine;

public class spawnPasserbies : MonoBehaviour{

    public GameObject passerbyPrefab;

    public Vector3 center;
    public Vector3 size;

    void Start(){
        spawnPasserby();
    }

    void Update(){
        if (Input.GetKeyDown("l")){
            spawnPasserby();
        }
    }

    public void spawnPasserby(){

        int totrandoms = 200;


        for (int i = 0; i < totrandoms; i++){

            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 1, Random.Range(-size.z / 2, size.z / 2));
            Instantiate(passerbyPrefab, pos, Quaternion.identity);
        }
    }
    private void OnDrawGizmosSelected(){
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
