using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NodeParent : MonoBehaviour
{
    public List<Node> nodes;

    private void Awake()
    {
     
       nodes = GetComponentsInChildren<Node>().ToList();
       nodes.OrderBy(i=>i.nodeldx);

    }
}
