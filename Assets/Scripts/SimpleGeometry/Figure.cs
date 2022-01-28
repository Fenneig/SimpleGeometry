using UnityEngine;

namespace SimpleGeometry
{
    public abstract class Figure : MonoBehaviour
    {
        [Range(1, 10)] [SerializeField] private int _size = 1;

        public int Size
        {
            get => _size;
            set
            {
                if (value >= 1 && value <= 10)
                    _size = value;
            }
        }

        public abstract void OnClick();
    }
}