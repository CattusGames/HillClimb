using UnityEngine;
using UnityEngine.SceneManagement;

public class Head : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Finish")
        {
            Debug.Log("Finish");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
