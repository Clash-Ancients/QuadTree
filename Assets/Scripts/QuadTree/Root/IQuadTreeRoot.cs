using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soul.Frameworks
{
    public interface IQuadTreeRoot<TItem, TNode>
        where TItem: IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {
       
    }
 
}

