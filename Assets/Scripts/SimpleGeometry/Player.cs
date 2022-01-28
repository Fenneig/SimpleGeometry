using System;
using UnityEngine;
using SimpleGeometry.GameObjectComponents;

namespace SimpleGeometry
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _maxEnergy;
        
        private Figure _figure;
        private int _moves;
        private int _energy;
        
        
        public Figure Figure => _figure;

        [SerializeField] private bool _isTriangleExtensionOn;

        public bool IsTriangleExtensionOn
        {
            get => _isTriangleExtensionOn;
            set => _isTriangleExtensionOn = value;
        }

        public int Moves
        {
            get => _moves;
            set
            {
                _moves = value;
                OnChange?.Invoke();
            }
        }

        public int Energy {
            get => _energy;
            set
            {
                _energy = value;
                OnChange?.Invoke();
            }
        }

        public int MaxEnergy => _maxEnergy;
        
        public static Player Instance;

        public event Action OnChange;

        public event Action<Figure> OnFigureAction;

        private void Awake()
        {
            _moves = 0;
            if (!Instance)
            {
                Instance = this;
                DontDestroyOnLoad(Instance);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public bool IsHoldingFigure() => _figure != null;


        public void Capture(Figure figure)
        {
            _figure = figure;
            OnFigureAction = null;
        }

        public void InvokeFigureAction(Figure target)
        {
            OnFigureAction?.Invoke(target);
            Release();
        }

        public void Release()
        {
            _figure = null;
        }
    }
}