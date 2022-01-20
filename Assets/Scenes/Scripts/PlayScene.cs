using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScene : MonoBehaviour
{

    public Animator[] anims;
    public Cloth poncho;
    public Button[] buttonsToDeactivate;
    public GameObject rotateManager;
    public void PlayGame(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadPose()
    {
        StartCoroutine(LoadPoseScene());
    }
    IEnumerator LoadPoseScene()
    {
        rotateManager.transform.rotation = new Quaternion(0, 0, 0, 0);
        poncho.useGravity = true;
        poncho.externalAcceleration = new Vector3(0, -50, 0);
        poncho.randomAcceleration = new Vector3(0, -20, 0);
        anims[ChangeWeight.weight].SetBool("Walking", false);
        foreach (Button button in buttonsToDeactivate)
        {
            button.interactable = false;
        }
        yield return new WaitForSeconds(12f);
        SceneManager.LoadScene("PoseScene");
    }
}
