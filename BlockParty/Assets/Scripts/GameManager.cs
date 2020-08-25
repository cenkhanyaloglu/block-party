using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float timeSlowMultiplier;

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        // Before 1 sec Wait - Slow Time
        Time.timeScale = 1f / timeSlowMultiplier;
        Time.fixedDeltaTime /= timeSlowMultiplier;

        yield return new WaitForSeconds(1f / timeSlowMultiplier);

        // After 1 sec Wait - Return Time to Normal
        Time.timeScale = 1f;
        Time.fixedDeltaTime *= timeSlowMultiplier;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
