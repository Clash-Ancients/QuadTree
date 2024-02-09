using UnityEngine;

namespace Soul.Frameworks
{
    
    public class RenderItem : GameObjectItem
    {
        // Start is called before the first frame update
        public override Bounds GetBounds()
        {
            return new Bounds();
        }

    }

}
