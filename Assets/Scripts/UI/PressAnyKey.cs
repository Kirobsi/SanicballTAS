using UnityEngine;
using UnityEngine.Events;

namespace Sanicball.UI
{
    public class PressAnyKey : MonoBehaviour
    {
        public UnityEvent onAnyKeyPressed;

        public float timer = 10f;
        private float spin = 0f;

        private void Update()
        {
            if (timer > 0f)
            {
                timer -= (1.0f / 60.0f);
            }
            else {
                if (spin == 0f) spin = 0.01f;
                if (spin < 1000000f)
                {
                    spin += (1.0f / 60.0f) * spin;
                }
            }
            transform.Rotate(0f, 0f, spin * (1.0f / 60.0f));

            if (Input.anyKeyDown)
            {
                onAnyKeyPressed.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
