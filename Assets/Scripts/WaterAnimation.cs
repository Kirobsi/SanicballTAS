using UnityEngine;

namespace Sanicball
{
    public class WaterAnimation : MonoBehaviour
    {
        public Vector2 speed;
        private Vector2 offset;

        private void Update()
        {
            offset += new Vector2(speed.x * (1.0f / 60.0f), speed.y * (1.0f / 60.0f));
            if (offset.x >= 1)
            {
                offset += new Vector2(-1, 0);
            }
            if (offset.y >= 1)
            {
                offset += new Vector2(0, -1);
            }
            GetComponent<Renderer>().material.SetTextureOffset("_MainTex", offset);
        }
    }
}