
using UnityEngine;
namespace Soul.Frameworks
{
    public abstract class QuadTreeMonoRoot<TItem, TNode> : MonoBehaviour, IQuadTreeRoot<TItem, TNode>
        where TItem : IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {
        protected void Start()
        {
            Init();
        }

        protected void OnEnable()
        {
            Init();
        }

        protected void Init()
        {
            Debug.Log("Init");
        }
        
    }
}