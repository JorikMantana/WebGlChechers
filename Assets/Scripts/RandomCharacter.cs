using UnityEngine;
using UnityEngine.UI;

public class RandomCharacter : MonoBehaviour
{
    [SerializeField] private Sprite[] images;
    [SerializeField] private Image mainImage;


    void Start()
    {
        mainImage.sprite = images[Random.Range(0, images.Length)];
    }
}
