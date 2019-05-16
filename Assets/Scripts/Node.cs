using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node
{
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

    public List<Node> Neighbors;
}
