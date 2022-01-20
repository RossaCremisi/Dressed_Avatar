using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerLoading : MonoBehaviour
{
    [SerializeField]
    public float delayScene = 20f;
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
