using UnityEngine;

public class Boton : MonoBehaviour
{
    [SerializeField] private GameObject door;
    public void OpenDoor()
    {
       // Destroy(door, 2f);
       door.SetActive(false);
    }
}
