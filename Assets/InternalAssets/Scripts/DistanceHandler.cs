using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DistanceHandler : MonoBehaviour
{
    private const float _distanceForSphereEnabled = 2f;
    private const float _distanceForNextScene = 1f;

    [SerializeField] private Transform _greenCube;
    [SerializeField] private Transform _redCube;

    [SerializeField] private GameObject _spheres;
    [SerializeField] private TextMeshProUGUI _distanceText;

    private bool _loadTriggered = false;

    private void Update()
    {
        float distance = Vector3.Distance(_greenCube.position, _redCube.position);
        _spheres.SetActive(distance < _distanceForSphereEnabled);

        if (!_loadTriggered && distance < _distanceForNextScene)
        {
            _loadTriggered = true;
            SceneManager.LoadScene(1);
        }

        _distanceText.text = distance.ToString()[..Mathf.Clamp(4, 0, distance.ToString().Length)];
    }
}
