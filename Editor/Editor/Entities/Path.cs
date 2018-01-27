using JStudio.J3D;
using OpenTK;
using System;
using System.Windows.Data;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace WindEditor
{
	public partial class Path_v2
	{
		public PathPoint_v2 FirstNode { get; set; }

		/*public override void PostLoad()
		{
			base.PostLoad();

			// ToDo: Get the index of our first node, into the array of passed in entities.
			// assign that as our FirstNode, and then recursively walk the children assigning their next node,
			// etc. until we hit a end-of-path node. 
		}*/

        public override void PostLoad(List<WDOMNode> sceneList)
        {
            List<PathPoint_v2> points = (List<PathPoint_v2>)sceneList.OfType<PathPoint_v2>().ToList();
            int firstIndex = FirstEntryOffset / 16;

            FirstNode = points[firstIndex];
            FirstNode.SetUpLinkedList(points, firstIndex, NumberofPoints);
        }

		// override void PreSave(...)
		// {
		//		int NodeIndex = InList.GetNodesOfType<PathPoint_v1>().IndexOf(FirstNode);
		//		if(NodeIndex< 0)
		// 		{
		// 			Console.WriteLine("Warning blahblah null setting to zero to try and keep the game from crashing on load.");
		// 			NodeIndex = 0;
		// 		}
		// 
		//		// Set the property for FirstIndex to NodeIndex, etc etc.
		// 
		// }
	}
}
