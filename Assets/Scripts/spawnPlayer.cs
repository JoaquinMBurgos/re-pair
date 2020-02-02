using UnityEngine;

public class spawnPlayer : MonoBehaviour{

    public GameObject playerPrefab;
    public Vector3 center;
    public Vector3 size;

    void Start() {
        spawn();
    }


    public void spawn() {
        Vector3 pos = center + new Vector3(Random.Range(0, size.x / 2), 1, Random.Range(0 / 2, size.z / 2));
        Instantiate(playerPrefab, pos, Quaternion.identity);
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}