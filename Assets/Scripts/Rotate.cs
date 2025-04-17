using UnityEngine;

namespace Sanicball
{
    public class Rotate : MonoBehaviour
    {
        public Vector3 angle;

        // Use this for initialization
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(angle * (1.0f / 60.0f) * 10);
        }
    }
}