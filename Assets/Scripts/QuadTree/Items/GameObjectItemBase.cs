using UnityEngine;

namespace Soul.Frameworks
{
    
    public abstract class GameObjectItemBase<TItem, TNode> : MonoBehaviour, IItem<TItem, TNode>
        where TItem : IItem<TItem, TNode>
        where TNode : INode<TItem, TNode>
    {
        public abstract Bounds GetBounds();
        
        private void Start()
        {
            Init();
        }

        private void OnEnable()
        {
            Init();
        }

        protected virtual void Init()
        {
            Debug.Log("Init");
        }
    }

}
