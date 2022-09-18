using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {
//    private int maxRows = 17;
//    private int maxCols = 12;
//    public Sprite[] Sprites;
//    public List<Brick> RemainingBricks { get; set; }
//    private GameObject brickContainer;
//    private float initialBricksSpawnPositionx = -1.96f;
//    private float initialBricksSpawnPositiony = 3.325f;
//    public Brick brickPrefab;
//    private float shiftAmount = 0.365f;



//    public List<int[,]> LevelsData { get; set; }
//    public int CurrentLevel;
//    private void Start()
//    {
//        this.brickContainer = new GameObject("BricksContainer");
//        this.RemainingBricks = new List<Brick>();

//        this.LevelsData = this.LoadLevelsData();
//        this.GenerateBricks();

//    }
//    private void GenerateBricks()
//    {
//        int[,] currentLevelData = this.LevelsData[this.CurrentLevel];
//        float currentSpawnX = initialBricksSpawnPositionx;
//        float currentSpawnY = initialBricksSpawnPositiony;
//        float zShift = 0;
//        for(int row=0;row<this.maxRows;row++)
//        {
//            for (int col = 0; col < this.maxCols;col++)
//            {
//                int brickType = currentLevelData[row, col];
//                if(brickType>0)
//                {
//                    Brick newBrick = Instantiate(brickPrefab, new Vector3(currentSpawnX, currentSpawnY, 0, 0f - zShift), Quaternion.identity) as Brick;
//                    newBrick.Init(bricksContainer.transform, this.Sprites[brickType - 1], this.BrickColors[brickType], brickType);
                         
//                    this.RemainingBricks.AD
//                }

//            }
//        }
//    }
//    private List<int[,]> LoadLevelsData()
//    {
//        TextAsset text = Resources.Load("levels") as TextAsset;
//        string[] rows = text.text.Split(new string[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
//        List<int[,]> LevelsData = new List<int[,]>();
//    int[,] currentLevel = new int[maxRows, maxCols];
//    int currentRow = 0;
//    for(int row=0; row < rows.Length ; row++)
//        {
//            string line = rows[row];
//            if(line.IndexOf("--") == -1)
//            {
//                string[] bricks = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
//                    for(int col = 0; col< bricks.Length;col++)
//                {
//                    currentLevel[currentRow, col] = int.Parse(bricks[col]);
//                }
//                currentRow++;
//            }
//            else
//            {
//                currentRow = 0;
//                LevelsData.Add(currentLevel);
//                currentLevel = new int[maxRows, maxCols];


//            }

//        }
//        return LevelsData;

             
//    }
}
