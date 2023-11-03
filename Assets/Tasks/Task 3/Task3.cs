using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    
    private void Start()
    {
        var wall = Instantiate(_wallPrefab);
        wall.GetComponent<Rigidbody>().isKinematic = false;
    }
}
