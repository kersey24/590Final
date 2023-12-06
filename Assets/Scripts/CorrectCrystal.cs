using UnityEngine;

public class CrystalSocketInteraction : MonoBehaviour
{
    public GameObject correctCrystal; // Tag to identify the correct crystal for this socket
    public GameObject wallToDrop; // Reference to the wall object to drop
    public ParticleSystem particleEffect; // Reference to the particle effect to play



    private int counter;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == correctCrystal)
        {
            // Play the particle effect
            particleEffect.Play();
            col.gameObject.SetActive(false);
            counter = wallToDrop.GetComponent<DoorCounter>().counter += 1;
            if (counter == 6)
            {
                // rotate the wallToDrop.
                wallToDrop.transform.Rotate(0, 90, 0);
            }
        }
    }

}
