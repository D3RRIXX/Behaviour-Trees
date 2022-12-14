using Derrixx.BehaviourTrees.Runtime.Pure;
using UnityEngine;

namespace Derrixx.BehaviourTrees.Runtime.Behaviours
{
	public abstract class NodeBehaviour : MonoBehaviour, INode
	{
		public INode Parent { get; set; }

		public virtual void OnNodeEnter() { }
		public virtual void OnNodeExit() { }

		public abstract NodeState Execute();
		public virtual void InjectBlackboard(IBlackboard blackboard) { }
	}
}