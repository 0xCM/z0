//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;


    public abstract class OpSpec
    {        
        public Moniker Id {get;}            

        protected OpSpec(Moniker id)
        {
            this.Id = id;
        }
        
        public override string ToString()
            => Id;
    }

    public abstract class GroupOpSpec<S> : OpSpec
        where S : OpSpec
    {
        protected GroupOpSpec(Moniker id, S[] members)
            : base(id)
        {
            this.Members = members;
        }

        /// <summary>
        /// The group members
        /// </summary>
        public S[] Members {get;}

        public bool IsEmpty 
            => Members.Length == 0;

    }

    public abstract class RootedOpSpec : OpSpec
    {
        protected RootedOpSpec(Moniker id, MethodInfo method)
            : base(id)
        {
            this.Root = method;
        }

        public MethodInfo Root {get;}

    }
}