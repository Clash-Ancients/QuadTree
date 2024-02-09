using UnityEngine;
namespace Soul.Frameworks
{
    
    public interface IItem<TItem, TNode> 
        where TItem : IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {
        Bounds GetBounds();
    }

}
