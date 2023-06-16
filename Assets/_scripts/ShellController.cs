using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shell", menuName = "Characters/Shell", order = 1)]
public class ShellController : ScriptableObject
{

    [Header("Controllers")]
    [SerializeField]
    ShellState state;
    [SerializeField]
    MaterialController materialController;
    [SerializeField]
    ShellParticleController particleController;

    Renderer renderer;
    Transform spawnTransform, playerTransform;

    public void Initialize(Transform _playerTranform, Transform _spawnTransform, Renderer _renderer)
    {

        renderer = _renderer;
        spawnTransform = _spawnTransform;
        playerTransform = _playerTranform;
        materialController.changeMaterial(renderer, state);
        particleController.playSpawnParticle(spawnTransform, state);

    }

    public void onStateChange(ShellState _state)
    {
        if (state != _state)
        {
            state = _state;
            materialController.changeMaterial(renderer, state);
            particleController.playSpawnParticle(spawnTransform, state);
        }
    }
}
