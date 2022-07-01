using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private Image progressBar;
  
    public static string nextScene;

    private static SceneController instance;
    public static SceneController Instance
    {
        get
        {
            if (instance == null) instance = FindObjectOfType<SceneController>();
            return instance;
        }
    }
    public void OpenScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void Start()
    {
        StartCoroutine(LoadSceneProcess());
    }

    IEnumerator LoadSceneProcess()
    {
        progressBar.fillAmount = 0f;

        AsyncOperation op = SceneManager.LoadSceneAsync("LoadScene");
        op.allowSceneActivation = false; //로딩 90퍼에서 멈추기 그 동안 tip 스토리 보여주기

        float timer = .0f;

        while (!op.isDone)
        {
            yield return null;
            progressBar.fillAmount = 0;
            timer += Time.deltaTime /3;

            if (op.progress <= 0.9f)
            {
                progressBar.fillAmount = Mathf.Lerp(0f, 1f, timer);
                if (progressBar.fillAmount >= 1f)
                {
                    op.allowSceneActivation = true;
                    SceneController.Instance.OpenScene("MainScene");
                    //StopCoroutine(LoadSceneProcess());
                    yield break;
                }
            }
        }
    }
}
