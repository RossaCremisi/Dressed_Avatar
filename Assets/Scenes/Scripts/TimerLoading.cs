using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerLoading : MonoBehaviour
{
    [SerializeField]
    private float delayScene = 20f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayScene)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
