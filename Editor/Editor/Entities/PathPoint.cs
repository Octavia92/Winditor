using JStudio.J3D;
using OpenTK;
using System;
using System.Windows.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace WindEditor
{
    public partial class PathPoint_v2
	{
        public PathPoint_v2 LastNode { get; set; }
		public PathPoint_v2 NextNode { get; set; }

        override protected void VisibleDOMNode_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //if (e.PropertyName == "NextNode")
            //    PostLoad();
        }

        public override void PostLoad(List<WDOMNode> sceneList)
        {
            base.PostLoad(sceneList);
        }

        public void SetUpLinkedList(List<PathPoint_v2> nodes, int index, int nodeCount)
        {
            LastNode = nodes[index];
            index++;
            nodeCount--;

            if (nodeCount > 0)
            {
                NextNode = nodes[index];
                NextNode.SetUpLinkedList(nodes, index, nodeCount);
            }
        }

		#region IRenderable
		override public void AddToRenderer(WSceneView view)
		{
			view.AddOpaqueMesh(this);
		}

		override public void Draw(WSceneView view)
		{
			base.Draw(view);

			if(NextNode != null)
			{
				m_world.DebugDrawLine(Transform.Position, NextNode.Transform.Position, WLinearColor.Black, 50f, 0f);
			}
		}

		override public float GetBoundingRadius()
		{
			float baseBB = base.GetBoundingRadius();
			if(NextNode != null)
			{
				baseBB += (Transform.Position - NextNode.Transform.Position).Length;
			}

			return baseBB;
		}
		#endregion
	}
}
