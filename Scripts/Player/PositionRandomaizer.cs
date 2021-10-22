 using UnityEngine;

class PositionRandomaizer : MonoBehaviour
{
    [SerializeField] private float _approximateRadius; 
    [SerializeField] private float height; 
    public Vector3 CountPosition(float from, float to )
    {
        Vector3 position = new Vector3(Random.Range(from, to), height);
        return  position;
    }
}