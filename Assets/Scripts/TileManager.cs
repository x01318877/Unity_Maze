using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    //public GameObject leftTilePrefab;
    //public GameObject topTilePrefab;
    
    //Random array[]
    public GameObject[] tilePrefabs;

    //which tile we need to place this prefab next to
    public GameObject currentTile;

    //static can access class level
    private static TileManager instance;

    //stack is a collection, for reusing the the 50 cubes
    private Stack<GameObject> leftTiles = new Stack<GameObject>();
    //public access the live stack
    public Stack<GameObject> LeftTiles
    {
        get{return leftTiles;}
        set{leftTiles = value;}
    }
    
    private Stack<GameObject> topTiles = new Stack<GameObject>();
    //public access the live stack
    public Stack<GameObject> TopTiles
    {
        get{return topTiles;}
        set{topTiles = value;}
    }

    public static TileManager Instance
    {
        get
        {
            //haven't access yet
            if (instance == null) {
                //find the tilemanager her and make a reference for instance that can access other places
                instance = GameObject.FindObjectOfType<TileManager>();
            }
            return instance;
        }
        
    }


    // Use this for initialization
    void Start () {
        CreateTiles(100);

        for (int i = 0; i < 50; i++) {
            SpawnTile();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //how many times we should create of each in amount
    public void CreateTiles(int amount) {
        for (int i = 0; i < amount; i++) {
            LeftTiles.Push(Instantiate(tilePrefabs[0]));
            TopTiles.Push(Instantiate(tilePrefabs[1]));

            TopTiles.Peek().name = "TopTile";
            TopTiles.Peek().SetActive(false);

            LeftTiles.Peek().name = "LeftTile";
            LeftTiles.Peek().SetActive(false);
        }

    }

    public void SpawnTile() {
        //check if we have some tiles to take before we try to spawn them
        if (LeftTiles.Count == 0  || TopTiles.Count == 0) {
            CreateTiles(10);
        }

        //CurrentTile -> Tile -> LeftAttachPoint
        //currentTile = Instantiate(leftTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
        //currentTile = Instantiate(topTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(1).position, Quaternion.identity);

        //Generating a random number between 0 and 1
        int randomIndex = Random.Range(0, 2);

        if (randomIndex == 0)
        {
            //pop remove the tile from the stack
            GameObject tmp = LeftTiles.Pop();
            //in createtiles we set false
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;
        }
        else if(randomIndex == 1){
            //pop remove the tile from the stack
            GameObject tmp = TopTiles.Pop();
            //in createtiles we set false
            tmp.SetActive(true);
            tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position;
            currentTile = tmp;
        }

        int spawnPickup = Random.Range(0, 10);
        if (spawnPickup == 0) {
            //enable the pickup same like tick,pickup is the second child
            currentTile.transform.GetChild(1).gameObject.SetActive(true);
        }

        //Left -> Element0, Top -> Element1
        //currentTile = Instantiate(tilePrefabs[0], currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
        //currentTile = Instantiate(tilePrefabs[1], currentTile.transform.GetChild(0).transform.GetChild(1).position, Quaternion.identity);
        //currentTile = Instantiate(tilePrefabs[randomIndex], currentTile.transform.GetChild(0).transform.GetChild(randomIndex).position, Quaternion.identity);
    }

    public void ResetGame() {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
    }
}
