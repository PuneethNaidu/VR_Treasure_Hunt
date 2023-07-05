using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
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
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

    public void MoveObjectAndChangeSceneOnClick()
    {
        isMoving = true;
    }
}

