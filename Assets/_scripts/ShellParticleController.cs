using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shell", menuName = "Characters/Shell Particle Controller", order = 1)]
public class ShellParticleController : ScriptableObject
{
    [Header("Spawn particles")]
    [SerializeField]
    ParticleSystem allySpawnParticleSystem;
    [SerializeField]
    ParticleSystem enemySpawnParticleSystem;
    [SerializeField]
    ParticleSystem hollowSpawnParticleSystem;

    public void playSpawnParticle(Transform position, ShellState state)
    {
        switch (state)
        {
            case ShellState.ALLY: {
                    Instantiate(allySpawnParticleSystem, position);
                    break; 
                }
            case ShellState.ENEMY:
                {
                    Instantiate(enemySpawnParticleSystem, position);
                    break;
                }
            case ShellState.HOLLOW:
                {
                    Instantiate(hollowSpawnParticleSystem, position);
                    break;
                }
            default: break;
        }
    }

}
