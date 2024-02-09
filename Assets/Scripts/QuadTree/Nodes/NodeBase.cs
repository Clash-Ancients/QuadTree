using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Soul.Frameworks
{
    
    public class NodeBase<TItem, TNode> : INode<TItem, TNode>
        where TItem : IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {

        public Bounds Bounds
        {
            get;
            set;
        }
        
    }

}
