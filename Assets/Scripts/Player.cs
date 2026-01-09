using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft=_numSeeds;
        _numSeedsPlanted=0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
    }

    private void Update()
    {
        MoveAround();
        PlantSeed();
    }

    void MoveAround()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 vector3 = new Vector3(horizontal,vertical,0f);
        _playerTransform.position += vector3*_speed*Time.deltaTime;
    }

    public void PlantSeed ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsLeft > 0)
            {
                Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
                _numSeedsLeft--;
                _numSeedsPlanted++;
                _plantCountUI.UpdateSeeds(_numSeedsLeft,_numSeedsPlanted);
            }
        }
    }
}
