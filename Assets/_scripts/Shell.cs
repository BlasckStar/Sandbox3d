using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    new Renderer renderer;

    [SerializeField]
    Transform particleSpawnTransform;

    [SerializeField]
    ShellController shellController;

    [SerializeField]
    ShellNavigation shellNavigation;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
        shellController.Initialize(this.transform, particleSpawnTransform, renderer);
    }

    public void changeBt(string state)
    {
        if(state == "1")
            shellController.onStateChange(ShellState.ALLY);
        if (state == "2")
            shellController.onStateChange(ShellState.ENEMY);
        if (state == "3")
            shellController.onStateChange(ShellState.HOLLOW);
    }
}
