using UnityEngine.SceneManagement;
using UnityEngine;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("You win");
        SceneManager.LoadScene("Level01");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
