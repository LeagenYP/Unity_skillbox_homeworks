using UnityEditor;
using UnityEngine;

public class Task_1 : MonoBehaviour
{

    public float speed;
    public Vector3[] target;
    public int arraySize;

    private int currentIndex = 0;

    private bool goForwardFlag = true;
    private bool goBackFlag = false;

    public GameObject cubeStartPositionMark;

    private void Start()
    {
        target = new Vector3[arraySize];

        for (int i = 0; i < target.Length; i++)
        {
            int x = Random.Range(0, 5);
            int y = Random.Range(0, 5);
            target[i] = new Vector3(x, y);
        }
        transform.position = target[0];
        cubeStartPositionMark.transform.position = target[0];
    }

    void Update()
    {
        if (goForwardFlag)
        {
            GoForward();
        } else if (goBackFlag)
        {
            GoBack();
        } 
    }

    private void GoForward()
    {
        transform.position = Vector3.MoveTowards(transform.position, target[currentIndex], Time.deltaTime * speed);

        if (transform.position == target[currentIndex] && currentIndex <= arraySize)
        {
            currentIndex++;
        }

        if (currentIndex >= arraySize)
        {
            currentIndex--;
            goForwardFlag = false;
            goBackFlag = true;
        }
        
    }

    private void GoBack()
    {
        transform.position = Vector3.MoveTowards(transform.position, target[currentIndex], Time.deltaTime * speed);

        if (transform.position == target[currentIndex])
        {
            currentIndex--;
        }

        if (currentIndex <= 0)
        {
            goBackFlag = false;
            goForwardFlag = true;
        }
    }
}
