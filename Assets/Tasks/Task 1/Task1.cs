using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetScale = new(2, 2, 2);
    
    private void Start()
    {
        var wall = Instantiate(_wallPrefab);
        // сохраняем ссылку на инстанциированный объект в переменную для последующего доступа
        wall.localScale = _tagetScale;
    }
}
