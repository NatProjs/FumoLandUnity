using UnityEngine;

public class CloneSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public KeyCode spawnKey = KeyCode.C;

    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            Instantiate(playerPrefab, transform.position, transform.rotation);
        }
    }
}
