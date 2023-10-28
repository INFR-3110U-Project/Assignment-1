using System.Collections.Generic;
using UnityEngine;

public enum PickupType
{
    Loot_Health,
    Loot_Jetpack,
    Pickup_Blaster,
    Pickup_Health,
    Pickup_Jetpack,
    Pickup_Launcher,
    Pickup_Shotgun
}

public class PickupFactory : MonoBehaviour
{
    private Dictionary<PickupType, GameObject> pickupPrefabs;

    public GameObject LootHealthPrefab;
    public GameObject LootJetpackPrefab;
    public GameObject PickupBlasterPrefab;
    public GameObject PickUpHealthPrefab;
    public GameObject PickupJetpackPrefab;
    public GameObject PickupLauncherPrefab;
    public GameObject PickupShotgunPrefab;

    public PickupFactory()
    {
        // Initialize the dictionary with mappings between PickupType and prefab GameObjects.
        // For example: pickupPrefabs[PickupType.Loot_Health] = healthLootPrefab;
    }

    public GameObject CreatePickup(PickupType type)
    {
        GameObject prefab = null;

        // Determine the prefab based on the type
        switch (type)
        {
            case PickupType.Loot_Health:
                prefab = LootHealthPrefab;
                break;
            case PickupType.Loot_Jetpack:
                prefab = LootJetpackPrefab;
                break;
            case PickupType.Pickup_Blaster:
                prefab = PickupBlasterPrefab;
                break;
            case PickupType.Pickup_Health:
                prefab = PickUpHealthPrefab;
                break;
            case PickupType.Pickup_Jetpack:
                prefab = PickupJetpackPrefab;
                break;
            case PickupType.Pickup_Launcher:
                prefab = PickupLauncherPrefab;
                break;
            case PickupType.Pickup_Shotgun:
                prefab = PickupShotgunPrefab;
                break;
            // Add cases for other pickup types
            default:
                Debug.LogError("Invalid pickup type: " + type);
                break;
        }
        // Instantiate the chosen prefab and return it
        return Instantiate(prefab);
    }
}