using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node
{
    //public static Node GetNode;
   public Node()
    {
        Gscore = 0;
        Hscore = 0;
        Position = Vector2.zero;
    }

   public Node(Vector2 pos)
    {
        Gscore = 0;
        Hscore = 0;

        Position = pos;
    }

    public Vector2 Position;

    public int Gscore;

    public int Hscore;

    public int Fscore
    {
        
        get
        {
            return Gscore + Hscore;
        }
    }

    public void CalcG(Node n)
    {

        int movementCost = 0;

        foreach(Node Nei in Neighbors)
        {
            if (Nei.Position.x == Position.x || Nei.Position.y == Position.y)
            {
                movementCost = 10;
            }

            else
            {
                movementCost = 14;
            }
        }

        int tentG;

        tentG = movementCost + Gscore;

        if (Parent != null)
        {
           if (tentG < Gscore)
            {
                Parent = n;
                Gscore = tentG;
            }
        }

        else
        {
            Parent = n;
            Gscore = tentG;
        }
    }

    public Node Parent;

    public List<Node> Neighbors;
}
