using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField]GameObject canonBallPrefab;
    [SerializeField]Transform spawnPoint;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 4)
        {
            Instantiate(canonBallPrefab, spawnPoint.position, spawnPoint.rotation);
            timer = 0;
        }
    }
}
