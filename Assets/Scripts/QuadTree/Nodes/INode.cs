using UnityEngine;
namespace Soul.Frameworks
{
    public interface INode<TItem, TNode> 
        where TItem : IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {
        Bounds Bounds { get; set; }
    }
}
