using UnityEngine;

public class DirectedParticle : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        transform.LookAt(_target.position);
    }
}
