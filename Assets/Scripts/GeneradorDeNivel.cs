using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeNivel : MonoBehaviour
{
    public Texture2D mapa;
    public ColorAPrefab[] colorMappings;
    public GameObject reference;
    void Start()
    {
        LevelGenerator();
    }
    private void LevelGenerator()
    {
        for (int x = 0; x < mapa.width; x++)
        {
            for (int y = 0; y < mapa.height; y++)
            {
                GenerateTile(x, y);
            }
        }

        transform.rotation = reference.transform.rotation;
        transform.position = reference.transform.position;
        transform.localScale = reference.transform.localScale;
    }

    void GenerateTile(int x, int y)
    {
        Color pixelColor = mapa.GetPixel(x, y);

        if (pixelColor.a == 0)
        {
            return;
        }

        foreach (ColorAPrefab colorMapping in colorMappings)
        {
            if (colorMapping.color.Equals(pixelColor))
            {

                Vector2 position = new Vector2(x, y);
                Instantiate(colorMapping.prefab, position, colorMapping.prefab.transform.rotation, transform);
            }
        }
    }
}
