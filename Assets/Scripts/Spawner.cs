using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minheigth = -1f;
    public float maxheigth = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate,spawnRate);   
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position,Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minheigth,maxheigth);
        
    }
}
