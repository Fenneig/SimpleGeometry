using UnityEngine;

namespace SimpleGeometry.GameObjectComponents
{
    public abstract class Figure : MonoBehaviour
    {
        [Range(3, 12)] [SerializeField] private int _size = 3;

        public bool IsMoveable { get; protected set; }

        public int Size
        {
            get => _size;
            set
            {
                if (value >= 3 && value <= 12)
                    _size = value;
            }
        }

        public abstract void OnClick();

        public void Resize()
        {
            transform.localScale = Vector3.one * _size;
        }
        
    }
}