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
        public OpIdentity Id {get;}            

        protected OpSpec(OpIdentity id)
        {
            this.Id = id;
        }
        
        public override string ToString()
            => Id;
    }

    public abstract class GroupOpSpec<S> : OpSpec
        where S : OpSpec
    {
        protected GroupOpSpec(OpIdentity id, S[] members)
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
        protected RootedOpSpec(OpIdentity id, MethodInfo method)
            : base(id)
        {
            this.Root = method;
        }

        public MethodInfo Root {get;}

    }
}