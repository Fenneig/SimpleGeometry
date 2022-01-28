using System;
using UnityEngine;

namespace SimpleGeometry
{
    public class Pool : MonoBehaviour
    {
        private Figure _figure;

        public Figure Figure => _figure;

        public static Pool Instance;

        public event Action FigureAction;

        private void Awake()
        {
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

        public bool IsHolidngFigure() => _figure != null;

        public void Capture(Figure figure)
        {
            _figure = figure;
        }

        public void Release()
        {
            _figure = null;
        }
    }
}