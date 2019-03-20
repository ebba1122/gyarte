using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour {


    public Tilemap Darkmap;
    public Tilemap Blurredmap;
    public Tilemap Backgroundmap;

    public Tile Darktile;
    public Tile Blurredtile;

    void Start()
    {
        Darkmap.origin = Blurredmap.origin = Backgroundmap.origin;
        Darkmap.size = Blurredmap.size = Backgroundmap.size;
    
        foreach (Vector3Int p in Darkmap.cellBounds.allPositionsWithin)
        {
            Darkmap.SetTile(p, Darktile);
        }

        foreach (Vector3Int p in Blurredmap.cellBounds.allPositionsWithin)
        {
            Blurredmap.SetTile(p, Blurredtile);
        }
    }

    void Update()
    {
        
    }
}
