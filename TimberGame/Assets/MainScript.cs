using UnityEngine;

namespace TimberGame
{
    public class MainScript : MonoBehaviour
    {
        public GameObject FelpudoPlayer;
        public GameObject FelpudoIdle;
        public GameObject FelpudoHit;

        private float _horizontalScale;

        private void Start()
        {
            _horizontalScale = transform.localScale.x;
            FelpudoHit.SetActive(false);

        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    HitRight();
                }
                else
                {
                    HitLeft();
                }
            }
        }

        private void HitRight()
        {
            FelpudoIdle.SetActive(false);
            FelpudoHit.SetActive(true);
            FelpudoPlayer.transform.position = new Vector2(0.7f,
                FelpudoPlayer.transform.position.y);
            FelpudoPlayer.transform.localScale = new Vector2(-_horizontalScale,
                FelpudoPlayer.transform.localScale.y);
            Invoke("SetIdle", 0.25f);
        }

        private void HitLeft()
        {
            FelpudoIdle.SetActive(false);
            FelpudoHit.SetActive(true);
            FelpudoPlayer.transform.position = new Vector2(-0.7f,
                FelpudoPlayer.transform.position.y);
            FelpudoPlayer.transform.localScale = new Vector2(_horizontalScale,
                FelpudoPlayer.transform.localScale.y);
            Invoke("SetIdle", 0.25f);
        }

        private void SetIdle()
        {
            FelpudoIdle.SetActive(true);
            FelpudoHit.SetActive(false);
        }
    }
}