using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void onTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hero"))
            SceneManager.LoadScene("TheForest");
    }


}
