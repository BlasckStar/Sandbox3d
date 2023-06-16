using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Shell", menuName = "Characters/Material Controller", order = 1)]
public class MaterialController : ScriptableObject
{
    [SerializeField]
    Material allyMaterial;
    [SerializeField]
    Material enemyMaterial;
    [SerializeField]
    Material hollowMaterial;

    public void changeMaterial(Renderer renderer, ShellState state) {

        switch (state){
            case ShellState.ALLY: renderer.material = allyMaterial;
                break;
            case ShellState.ENEMY: renderer.material = enemyMaterial;
                break;
            case ShellState.HOLLOW: renderer.material = hollowMaterial;
                break;
            default:
                renderer.material = hollowMaterial;
                break;
        }

    }

}
