using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Astar {

    private static Dictionary<Point, Node> nodes;

    private static void CreateNodes()
    {
        nodes = new Dictionary<Point, Node>();

        foreach(TileScript tile in LevelManager.Instance.Tiles.Values)
        {
            nodes.Add(tile.GridPosition, new Node(tile)); 
        }
    }

    public static void GetPath(Point start)
    {

        if(nodes == null)
        {
            CreateNodes();
        }

        HashSet<Node> openList = new HashSet<Node>();

        Node currentNode = nodes[start];

        openList.Add(currentNode);

        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                Point neighbourPos = new Point(currentNode.GridPosition.x - x, currentNode.GridPosition.y - y);

                if (LevelManager.Instance.InBounds(neighbourPos) && LevelManager.Instance.Tiles[neighbourPos].walkAble && neighbourPos != currentNode.GridPosition)
                {
                    Node neighBour = nodes[neighbourPos];
              
                }             
               
               
            }
        }

        //*****Dit is alleen voor debuggen moet later verwijderd worden
        GameObject.Find("AStarDebugger").GetComponent<AstarDebugger>().DebugPath(openList);
    }
	
}
