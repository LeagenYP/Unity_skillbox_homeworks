using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Task_2 : MonoBehaviour
{

    public float speed;

    Transform activeRunner;
    Transform target;
    private int runnerCouner = 0;
    private bool runnerMoving = true;

    public Transform[] runners;
    private Transform startPosition;

    public AudioSource VictorySound;

    void Start()
    {
        activeRunner = runners[0];
        target = runners[1];
    }


    void Update()
    {
        if (runnerMoving)
        {
            MoveRunner(activeRunner, target);
            SwitchRunner(activeRunner, target, runnerCouner);
        }
    }

    private void SwitchRunner(Transform _activeRunner, Transform _target, int nextRunnerIndex)
    {
        if (_activeRunner.position == _target.position)
        {
            activeRunner = target;
            if (nextRunnerIndex != runners.Length)
            {
                runnerCouner++;
                target = runners[nextRunnerIndex];
            }
            else
            {
                runnerMoving = false;
                VictorySound.Play();
            }
        }   
    }

    private void MoveRunner(Transform activeRunner, Transform target)
    {
        activeRunner.LookAt(target);
        activeRunner.position = Vector3.MoveTowards(activeRunner.position, target.position, speed * Time.deltaTime);
    }
}
