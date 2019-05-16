using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour
{

    public List<Node> nodes;

    public int Width;

    public int Height;
    private void Awake()
    {
        nodes = new List<Node>();
        for (int x = 0; x < Width; x++)
        {
            for (int y = 0; y < Height; y++)
            {
                Node node = new Node(new Vector2(x, y));
                var nodeObj = GameObject.CreatePrimitive(PrimitiveType.Quad);
                nodeObj.transform.position = node.Position * 1.5f;
                nodes.Add(node);
            }
        }
    }

    void GetNeighbors(Node node)
    {
        int ind = nodes.IndexOf(node);


        List<int> ValidIndexes = new List<int>()
        {
            ind + 1, ind - 1, ind + Width, ind - Width, ind + Width + 1, ind + Width - 1, ind - Width - 1, ind - Width + 1
        };
        
        foreach (int id in ValidIndexes)
        {
            if (id < 0 || id >= nodes.Count)
            {
                node.Neighbors.Add(nodes[id]);
            }
        }
    }

    public List<Node> Astar(Node Start, Node Goal)
    {
        Node Current;
        List<Node> Open = new List<Node>();
        List<Node> Closed = new List<Node>();

        Current = Start;

        Closed.Add(Current);


        while (Current != Goal)
        {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
