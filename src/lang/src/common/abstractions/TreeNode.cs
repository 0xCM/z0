//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a node in a tree
    /// </summary>
    /// <typeparam name="N">The reifying subtype</typeparam>
    public abstract class TreeNode<N> : ITreeNode
        where N : TreeNode<N>, new()
    {
        public TreeNode()
        {
            Source = new N();
            Targets = Index<N>.Empty;
        }

        protected TreeNode(N source, Index<N> targets)
        {
            Source = source;
            Targets = targets;
        }

        protected TreeNode(Index<N> targets)
        {
            Source = new N();
            Targets = targets;
        }

        public virtual bool IsLeaf
            => false;

        /// <summary>
        /// Specifies whether the node is a root, in which case the source node will be empty
        /// </summary>
        public virtual bool IsRoot
            => false;

        public virtual bool IsEmpty
            => false;

        public N Source {get;}

        public Index<N> Targets {get;}

        public static EmptyNode<N> Empty
            => new EmptyNode<N>();
    }


    public class EmptyNode<N> : TreeNode<N>
        where N : TreeNode<N>, new()
    {
        public override bool IsEmpty
            => true;
    }

    public sealed class EmptyNode : EmptyNode<EmptyNode>
    {

    }

}