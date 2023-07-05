using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{
    public Transform objectToMove;
    public Transform destination;
    public float speed = 1.0f;
    public string nextSceneName;

    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            float step = speed * Time.deltaTime;
            objectToMove.position = Vector3.MoveTowards(objectToMove.position, destination.position, step);
            if (objectToMove.position == destination.position)
            {
                StartCoroutine(LoadNextSceneAsync());
                isMoving = false;
            }
        }
    }

    private IEnumerator LoadNextSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void MoveObjectAndChangeSceneOnClick()
    {
        isMoving = true;
    }

    
}
