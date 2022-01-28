using UnityEngine;

namespace SimpleGeometry
{
    public abstract class Figure : MonoBehaviour
    {
        [Range(1, 10)] [SerializeField] private int _size = 1;
        public int Size => _size;
    }
}