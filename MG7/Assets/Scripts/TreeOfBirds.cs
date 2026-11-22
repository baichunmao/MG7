using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    public GameObject[] birds;
    public Transform player;
    public float interactionDistance = 5f;
    private void Update()
    {
        if (player == null) return;
        foreach (GameObject bird in birds)
        {
            if (bird == null) continue;
            float distance = Vector3.Distance(player.position, bird.transform.position);
            if (distance <= interactionDistance)
            {
                bird.SetActive(true);
            }
        }
    }
}