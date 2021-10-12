using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class GeneradorDeNivel : MonoBehaviour
{
    public Texture2D mapa;
    public ColorAPrefab[] colorMappings;
    public GameObject reference;

    public Tablero tablero;
    public SokobanLevelManager lvlManager;

    public void Awake()
    {
        lvlManager = GameObject.Find("SokobanLevelManager").GetComponent<SokobanLevelManager>();
    }

    public void GenerateTile(int x, int y, Texture2D mapa)
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
                lvlManager.tablero.setearObjeto(colorMapping.prefab, position);
            }
        }
    }
}
