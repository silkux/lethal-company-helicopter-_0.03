using UnityEngine;
using BepInEx;
using BepInEx.Logging;

[BepInPlugin("com.yourname.myhelicoptermod", "My Helicopter Mod", "1.0.0")]
public class MyHelicopterMod : BaseUnityPlugin
{
    public GameObject? helicopterPrefab;

    private void Awake()
    {
        Logger.LogInfo("My Helicopter Mod loaded!");

        // Carga el prefab desde los assets del mod
        helicopterPrefab = Resources.Load<GameObject>("SeaHawk");

        if (helicopterPrefab != null)
        {
            // Instancia el helicóptero en la posición inicial del jugador
            Instantiate(helicopterPrefab, new Vector3(0, 5, 0), Quaternion.identity);
        }
        else
        {
            Logger.LogError("Helicopter prefab not found!");
        }
    }
}
