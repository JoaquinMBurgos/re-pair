using UnityEngine;

public class spawnTarget : MonoBehaviour{
    public GameObject targetPrefab;

    public Vector3 center;
    public Vector3 size;

    void Start(){
        spawn();
    }

    public void spawn(){
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, 0), 1, Random.Range(-size.z / 2, 0));
        Instantiate(targetPrefab, pos, Quaternion.identity);
    }
    private void OnDrawGizmosSelected(){
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
