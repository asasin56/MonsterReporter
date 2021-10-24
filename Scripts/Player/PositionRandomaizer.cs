 using UnityEngine;

 public class PositionRandomaizer : MonoBehaviour
{
    [SerializeField] private float _approximateRadius; 
    [SerializeField] private float height; 
    public virtual Vector3 CountPosition(Transform from, Transform to )
    {
        Vector3 position = new Vector3(Random.Range(from.position.x, to.transform.position.x), height);
        return  position;
    }
}